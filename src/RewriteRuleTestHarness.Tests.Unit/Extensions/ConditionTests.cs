using NUnit.Framework;
using RewriteRuleTestHarness.Models;
using RewriteRuleTestHarness.Models.Extensions;

namespace RewriteRuleTestHarness.Tests.Unit.Extensions
{
    [TestFixture]
    public class ConditionTests
    {
        [Test]
        public void should_match_input()
        {
            // given
            var condition = new Condition
            {
                IgnoreCase = false,
                Pattern = "^freddy$"
            };

            // when
            bool isMatch = condition.MatchesInput("freddy");

            // then
            Assert.That(isMatch, Is.True);
        }

        [Test]
        public void should_not_match_input()
        {
            // given
            var condition = new Condition
            {
                IgnoreCase = false,
                Pattern = "^freddy$"
            };

            // when
            bool isMatch = condition.MatchesInput("jogn");

            // then
            Assert.That(isMatch, Is.False);
        }
    }
}
