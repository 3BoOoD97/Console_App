using Console_App;

namespace TestProject1
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
            // Arrange
            int arg1 = 10;
            int arg2 = 5;
            int expected = 15;

            // Act
            int result = extensionMethods.addArgs(arg1, arg2);
            var s = new abd();

            // Assert
            Assert.AreEqual(expected, result);
            Assert.Pass();
        }
    }
}