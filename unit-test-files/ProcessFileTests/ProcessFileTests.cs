using System.Reflection;
using System.IO;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void GivenFile_WhenProcess_ThenResult()
        {
            // Given
            var target = new ProcessFile.ProcessFile();
            var testLocation = Assembly.GetExecutingAssembly().Location;

            var fileLocation = Path.Combine(Path.GetDirectoryName(testLocation), "TestFiles/TestFile.csv");
            // When
            var result = target.Process(fileLocation);

            // Then
            Assert.Pass();
        }

        [Test]
        public void GivenStream_WhenProcess_ThenResult()
        {
            // Given
            var target = new ProcessFile.ProcessFile();
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream("ProcessFileTests.TestFiles.TestFileEmbedded.csv");

            // When
            var result = target.Process(stream);

            // Then
            Assert.Pass();

        }
    }
}