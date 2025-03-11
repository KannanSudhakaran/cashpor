using CalcuBusinessLogicLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcBusinesLogicLib.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add_WhenCalled_ReturnsTheSumOfArguments()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 1;
            int b = 2;
            int exptected = 3;

            // Act
            var actual = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(actual,exptected);
        }

    }
}
