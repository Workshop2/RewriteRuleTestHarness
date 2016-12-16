using System.Text.RegularExpressions;

namespace RewriteRuleTestHarness.Models.Extensions
{
    public static class MatchExtensions
    {
        public static bool MatchesUrl(this Match match, string url)
        {
            RegexOptions matchType = match.IgnoreCase ? RegexOptions.IgnoreCase : RegexOptions.None;
            return Regex.IsMatch(url, match.Url, matchType);
        }
    }
}