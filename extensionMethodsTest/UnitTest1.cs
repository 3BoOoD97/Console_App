using Console_App;

namespace extensionMethodsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addTwoIntegers()
        {
            // Arrange
            var argument1 = extensionMethods.stringConverter("1");
            var argument2 = extensionMethods.stringConverter("2");
            var expected = 3;

            // Act
            var actual = extensionMethods.addArgs(argument1, argument2);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void addIntegerWithString()
        {
            // Arrange
            var argument1 = extensionMethods.stringConverter("1");
            var argument2 = extensionMethods.stringConverter("abc");
            var expected = "1abc";

            // Act
            var actual = extensionMethods.addArgs(argument1, argument2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addIntegerWithDouble()
        {
            // Arrange
            var argument1 = extensionMethods.stringConverter("1");
            var argument2 = extensionMethods.stringConverter("2.2");
            var expected = 3.2;
            // Act
            var actual = extensionMethods.addArgs(argument1, argument2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addTwoChars()
        {
            // Arrange
            var argument1 = extensionMethods.stringConverter("a");
            var argument2 = extensionMethods.stringConverter("b");
            var expected = "ab";

            // Act
            var actual = extensionMethods.addArgs(argument1, argument2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addTwoDoubles()
        {
            // Arrange
            var argument1 = extensionMethods.stringConverter("1.1");
            var argument2 = extensionMethods.stringConverter("2.2");
            var expected = 3.3000000000000003;

            // Act
            var actual = extensionMethods.addArgs(argument1, argument2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addDoubleWithChar()
        {
            // Arrange
            var argument1 = extensionMethods.stringConverter("1.1");
            var argument2 = extensionMethods.stringConverter("a");
            var expected = "1.1a";

            // Act
            var actual = extensionMethods.addArgs(argument1, argument2);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        /* Alwayes will fail because of the F at the end */
        public void addTwoFloats()
        {
            // Arrange
            var argument1 = extensionMethods.stringConverter("1.1F");
            var argument2 = extensionMethods.stringConverter("2.2F");
            var expected = 3.3F;

            // Act
            var actual = extensionMethods.addArgs(argument1, argument2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}