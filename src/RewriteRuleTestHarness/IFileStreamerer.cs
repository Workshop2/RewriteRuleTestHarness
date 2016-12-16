using System.IO;

namespace RewriteRuleTestHarness
{
    internal interface IFileStreamerer
    {
        Stream ReadFile(string path);
    }
}