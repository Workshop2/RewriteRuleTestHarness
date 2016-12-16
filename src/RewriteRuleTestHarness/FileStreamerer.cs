using System.IO;

namespace RewriteRuleTestHarness
{
    internal class FileStreamerer : IFileStreamerer
    {
        public Stream ReadFile(string path)
        {
            return File.OpenRead(path);
        }
    }
}