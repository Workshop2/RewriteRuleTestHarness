using NUnit.Framework;
using RewriteRuleTestHarness.Models;

namespace RewriteRuleTestHarness.Tests.Unit
{
    [TestFixture]
    public class InboundRulesTests
    {
        [Test]
        public void should_return_expected_rule_given_name()
        {
            // given
            var rules = new InboundRules
            {
                Rules = new[]
                {
                    new Rule { Name = "not-me" },
                    new Rule { Name = "not-me2" },
                    new Rule { Name = "not-me3" },
                    new Rule { Name = "me" },
                }
            };

            // when
            Rule rule = rules["me"];

            // then
            Assert.That(rule, Is.EqualTo(rules.Rules[3]));
        }

        [Test]
        public void should_return_expected_rule_given_index()
        {
            // given
            var rules = new InboundRules
            {
                Rules = new[]
                {
                    new Rule { Name = "not-me" },
                    new Rule { Name = "not-me2" },
                    new Rule { Name = "not-me3" },
                    new Rule { Name = "me" },
                }
            };

            // when
            Rule rule = rules[3];

            // then
            Assert.That(rule, Is.EqualTo(rules.Rules[3]));
        }
    }
}