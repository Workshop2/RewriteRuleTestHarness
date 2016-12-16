using NUnit.Framework;
using RewriteRuleTestHarness.Models;

namespace RewriteRuleTestHarness.Tests.Unit
{
    [TestFixture]
    public class ConditionsTests
    {
        [Test]
        public void should_return_expected_rule_given_name()
        {
            // given
            var conditions = new Conditions
            {
                ConditionList = new[]
                {
                    new Condition { Input = "not-me" },
                    new Condition { Input = "not-me" },
                    new Condition { Input = "not-me" },
                    new Condition { Input = "me" }
                }
            };

            // when
            Condition rule = conditions["me"];

            // then
            Assert.That(rule, Is.EqualTo(conditions.ConditionList[3]));
        }

        [Test]
        public void should_return_expected_rule_given_index()
        {
            // given
            var conditions = new Conditions
            {
                ConditionList = new[]
                {
                    new Condition(),
                    new Condition(),
                    new Condition(),
                    new Condition()
                }
            };

            // when
            Condition rule = conditions[3];

            // then
            Assert.That(rule, Is.EqualTo(conditions.ConditionList[3]));
        }
    }
}