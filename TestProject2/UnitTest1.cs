using Console_App;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var expected = 3;
            var argument1 = 1;
            var argument2 = 2;

            // Act
            var actual = extensionMethods.addArgs(argument1, argument2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}