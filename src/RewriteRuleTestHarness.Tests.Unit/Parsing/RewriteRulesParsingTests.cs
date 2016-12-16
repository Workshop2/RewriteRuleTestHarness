﻿using System.IO;
using System.Xml.Linq;
using Moq;
using NUnit.Framework;
using RewriteRuleTestHarness.Models;

namespace RewriteRuleTestHarness.Tests.Unit.Parsing
{
    [TestFixture]
    public class RewriteRulesParsingTests
    {
        private Mock<IFileStreamerer> _fileStreamer;

        [SetUp]
        public void Setup()
        {
            _fileStreamer = new Mock<IFileStreamerer>();
        }

        [Test]
        public void should_correctly_parse_single_rewrite_rule()
        {
            // given
            const string path = "i am a path";

            Stream stream = Resources.ResourceReader.StreamEmbeddedFile(Resources.ResourceReader.SingleRewriteRuleWithConditions);
            _fileStreamer
                .Setup(x => x.ReadFile(path))
                .Returns(stream);

            // when
            var parser = new RewriteRulesParser(_fileStreamer.Object);
            InboundRules rules = parser.ParseRules(path);

            // then
            Assert.That(rules.Rules.Length, Is.EqualTo(1));

            var rule = rules.Rules[0];
            Assert.That(rule.Name, Is.EqualTo("name-data"));
            Assert.That(rule.StopProcessing, Is.True);

            Assert.That(rule.Match.Url, Is.EqualTo("url-data"));
            Assert.That(rule.Match.IgnoreCase, Is.True);

            Assert.That(rule.Conditions.ConditionList.Length, Is.EqualTo(2));
            Assert.That(rule.Conditions.LogicalGrouping, Is.EqualTo(LogicalGroupingType.MatchAll));
            Assert.That(rule.Conditions.TrackAllCaptures, Is.False);

            Assert.That(rule.Conditions.ConditionList[0].Input, Is.EqualTo("input-data"));
            Assert.That(rule.Conditions.ConditionList[0].Pattern, Is.EqualTo("pattern-data"));
            Assert.That(rule.Conditions.ConditionList[0].Negate, Is.True);

            Assert.That(rule.Conditions.ConditionList[1].Input, Is.EqualTo("more-input-data"));
            Assert.That(rule.Conditions.ConditionList[1].Pattern, Is.EqualTo("more-pattern-data"));
            Assert.That(rule.Conditions.ConditionList[1].Negate, Is.False);

            Assert.That(rule.Action.Type, Is.EqualTo(ActionType.Rewrite));
            Assert.That(rule.Action.Url, Is.EqualTo("url-data"));
            Assert.That(rule.Action.AppendQueryString, Is.True);
        }
    }
}