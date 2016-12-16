using System;
using System.IO;
using NUnit.Framework;

namespace RewriteRuleTestHarness.Tests.Unit
{
    [TestFixture]
    public class FileStreamererTests
    {
        const string ExpectedText = "ghfllksadksdakjlsda9883483489";
        private string _path;

        [SetUp]
        public void Setup()
        {
            _path = Path.GetTempFileName();
            File.WriteAllText(_path, ExpectedText);
        }

        [TearDown]
        public void TearDown()
        {
            File.Delete(_path);
        }

        [Test]
        public void should_read_file()
        {
            // given

            // when
            var streamer = new FileStreamerer();
            using (Stream result = streamer.ReadFile(_path))
            {
                // then
                string contents = new StreamReader(result).ReadToEnd();
                Assert.That(contents, Is.EqualTo(ExpectedText));
            }
        }
    }
}