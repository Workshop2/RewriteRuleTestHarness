namespace RewriteRuleTestHarness.Models.Extensions
{
    public static class InboundRulesExtensions
    {
        public static Rule FirstRuleToMatchUrl(this InboundRules inboundRules, string url)
        {
            foreach (Rule rule in inboundRules.Rules)
            {
                if (rule.Match.MatchesUrl(url))
                {
                    return rule;
                }
            }

            return null;
        }
    }
}