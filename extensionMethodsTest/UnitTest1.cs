using Console_App;

namespace extensionMethodsTest
{
    [TestClass]
    public class UnitTest1
    {
        object argument1;
        object argument2;
        dynamic expected;
        dynamic actual;

        [TestMethod]
        public void addTwoIntegers()
        {
            // Arrange
            argument1 = 1;
            argument2 = 2;
            expected = 3;

            // Act
            actual = argument1.AddArgs(argument2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addIntegerWithString()
        {
            // Arrange
            argument1 = 1;
            argument2 = "abc";
            expected = "1abc";

            // Act
            actual = argument1.AddArgs(argument2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addIntegerWithDouble()
        {
            // Arrange
            argument1 = 1;
            argument2 = 2.2;
            expected = 3.2;

            // Act
            actual = argument1.AddArgs(argument2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addTwoChars()
        {
            // Arrange
            argument1 = "a";
            argument2 = "b";
            expected = "ab";

            // Act
            actual = argument1.AddArgs(argument2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addTwoDoubles()
        {
            // Arrange
            argument1 = 1.1;
            argument2 = 2.2;
            expected = 3.3000000;

            // Act
            actual = argument1.AddArgs(argument2);
            actual = Math.Round(actual, 7);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addDoubleWithChar()
        {
            // Arrange
            argument1 = 1.1;
            argument2 = "a";
            expected = "1.1a";

            // Act
            actual = argument1.AddArgs(argument2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addTwoFloats()
        {
            // Arrange
            argument1 = 1.1 F;
            argument2 = 2.2 F;
            expected = 3.3000002;

            // Act
            actual = argument1.AddArgs(argument2);
            actual = Math.Round(actual, 7);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}