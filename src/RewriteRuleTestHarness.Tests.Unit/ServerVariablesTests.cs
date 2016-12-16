using NUnit.Framework;
using RewriteRuleTestHarness.Models;

namespace RewriteRuleTestHarness.Tests.Unit
{
    [TestFixture]
    public class ServerVariablesTests
    {
        [Test]
        public void should_return_expected_rule_given_name()
        {
            // given
            var serverVariables = new ServerVariables()
            {
                ServerVariablesList = new[]
                {
                    new ServerVariable { Name = "not-me" },
                    new ServerVariable { Name = "not-me" },
                    new ServerVariable { Name = "not-me" },
                    new ServerVariable { Name = "me" },
                }
            };

            // when
            ServerVariable rule = serverVariables["me"];

            // then
            Assert.That(rule, Is.EqualTo(serverVariables.ServerVariablesList[3]));
        }

        [Test]
        public void should_return_expected_rule_given_index()
        {
            // given
            var serverVariables = new ServerVariables()
            {
                ServerVariablesList = new[]
                {
                    new ServerVariable(),
                    new ServerVariable(),
                    new ServerVariable(),
                    new ServerVariable()
                }
            };

            // when
            ServerVariable rule = serverVariables[3];

            // then
            Assert.That(rule, Is.EqualTo(serverVariables.ServerVariablesList[3]));
        }
    }
}