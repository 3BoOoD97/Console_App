
using Console_App; // Replace "YourNamespace" with the actual namespace where extensionMethods is defined

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace extensionMethod
{
    [TestClass]
    public class extensionMethodsTests
    {
        [TestMethod]
        public void AddArgs_WithIntegers_ReturnsCorrectSum()
        {
            // Arrange
            int arg1 = 10;
            int arg2 = 5;
            int expected = 15;

            // Act
            int result = extensionMethods.addArgs(arg1, arg2);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
