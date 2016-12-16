using NUnit.Framework;
using RewriteRuleTestHarness.Models;
using RewriteRuleTestHarness.Models.Extensions;

namespace RewriteRuleTestHarness.Tests.Unit.Extensions
{
    [TestFixture]
    public class InboundRulesTests
    {
        [Test]
        public void should_return_expected_rule_when_url_matches()
        {
            // given
            var rules = new InboundRules
            {
                Rules = new[]
                {
                    new Rule { Match = new Match { Url = "^wrong-url$", IgnoreCase = true } },
                    new Rule { Match = new Match { Url = "^another-wrong-url$", IgnoreCase = true } },
                    new Rule { Match = new Match { Url = "^correct-URL$", IgnoreCase = false } },
                    new Rule { Match = new Match { Url = "^correct-url$", IgnoreCase = true } },
                }
            };

            // when
            Rule rule = rules.FirstRuleToMatchUrl("correct-url");

            // then
            Assert.That(rule, Is.EqualTo(rules.Rules[3]));
        }

        [Test]
        public void should_return_null_if_nothing_is_matched()
        {
            // given
            var rules = new InboundRules
            {
                Rules = new[]
                {
                    new Rule { Match = new Match { Url = "^wrong-url$", IgnoreCase = true } },
                    new Rule { Match = new Match { Url = "^another-wrong-url$", IgnoreCase = true } },
                    new Rule { Match = new Match { Url = "^correct-URL$", IgnoreCase = false } },
                    new Rule { Match = new Match { Url = "^correct-url$", IgnoreCase = true } },
                }
            };

            // when
            Rule rule = rules.FirstRuleToMatchUrl("NOPE");

            // then
            Assert.That(rule, Is.Null);
        }
    }
}