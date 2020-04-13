using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Given
            var target = new ProcessFile.ProcessFile();

            // When
            var result = target.Process("");

            // Then
            Assert.Pass();
        }
    }
}