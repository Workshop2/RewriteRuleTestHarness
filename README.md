[![Build status](https://ci.appveyor.com/api/projects/status/p2qtxrxry7y7gilw?svg=true)](https://ci.appveyor.com/project/Workshop2/RewriteRuleTestHarness)[![Nuget.org](https://img.shields.io/nuget/v/RewriteRuleTestHarness.svg?style=flat)](https://www.nuget.org/packages/RewriteRuleTestHarness)

# RewriteRuleTestHarness
A fully tested simple nuget package to help you test Rewrite rules in IIS.

The xml is parsed into managed objects which makes it really easy to test things are as expected. There are even some helpful extension methods to test regex matching.

## Nuget Install
```powershell
Install-Package RewriteRuleTestHarness
```

## Example usage
```csharp
var parser = new RewriteRulesParser();
InboundRules rules = parser.ParseInboundRules("C:\path\to\rewriterules.xml");

if(rules.Match.MatchesUrl("some-url-to-test"))
{
  Console.WriteLine("YAY");
}

Rule rule = rules.FirstRuleToMatchUrl("correct-url");
```
