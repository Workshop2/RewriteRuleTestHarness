using System;
using System.IO;
using System.Reflection;

namespace RewriteRuleTestHarness.Tests.Unit.Resources
{
    public class ResourceReader
    {
        public const string SingleRewriteRuleWithConditions = "single-rewrite-rule-with-conditions.xml";

        public static string ReadEmbeddedFile(string file)
        {
            string textContent;
            using (var reader = new StreamReader(StreamEmbeddedFile(file)))
            {
                textContent = reader.ReadToEnd();
            }

            return textContent;
        }

        public static Stream StreamEmbeddedFile(string file)
        {
            string namespacePath = typeof(ResourceReader).Namespace;
            string resourcePath = $"{namespacePath}.{file}";

            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath);
            if (stream == null)
            {
                throw new InvalidOperationException($"Unable to find '{resourcePath}' as an embedded resource");
            }
            
            return stream;
        }
    }
}