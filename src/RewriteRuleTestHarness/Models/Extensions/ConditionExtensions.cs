using System.Text.RegularExpressions;

namespace RewriteRuleTestHarness.Models.Extensions
{
    public static class ConditionExtensions
    {
        public static bool MatchesInput(this Condition condition, string input)
        {
            RegexOptions matchType = condition.IgnoreCase ? RegexOptions.IgnoreCase : RegexOptions.None;
            return Regex.IsMatch(input, condition.Pattern, matchType);
        }
    }
}