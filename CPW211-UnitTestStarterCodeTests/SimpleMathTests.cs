using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Arrange
            double expected = num1 + num2;
            // Act
            double actual = SimpleMath.Add(num1, num2);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double a, double b)
        {
            // Arrange
            double expected = a * b;
            // Act
            double actual = SimpleMath.Multiply(a, b);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(5, 0)]
        [DataRow(0, 0)]
        [DataRow(-1, 0)]
        [DataRow(0, -0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double a, double b)
        {
            // Arrange
            // Assert => Act
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(a, b));
        }


        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        public void Divide_WithValidNumbers_ReturnsResult(double a, double b)
        {
            // Arrange
            double expected = a / b;
            // Act
            double actual = SimpleMath.Divide(a, b);
            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            double a = 5;
            double b = 10;
            double expected = a - b;
            // Act
            double actual = SimpleMath.Subtract(a, b);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}