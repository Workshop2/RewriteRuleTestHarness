using System.Text.RegularExpressions;

namespace RewriteRuleTestHarness.Models.Extensions
{
    public static class InboundRulesExtensions
    {
        public static Rule FirstRuleToMatchUrl(this InboundRules inboundRules, string url)
        {
            foreach (Rule rule in inboundRules.Rules)
            {
                RegexOptions matchType = rule.Match.IgnoreCase ? RegexOptions.IgnoreCase : RegexOptions.None;
                if (Regex.IsMatch(url, rule.Match.Url, matchType))
                {
                    return rule;
                }
            }

            return null;
        }
    }
}