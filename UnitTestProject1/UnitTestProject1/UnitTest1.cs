using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{

    public class CalculatorTests
    {

        public void TestPressEquals()
        {
            Calculator calculator = new Calculator();
            calculator.Enter(2m);
            calculator.PressPlus();
            calculator.Enter(2m);
            calculator.PressEquals();
            Assert.AreEqual(4m, calculator.Display);
        }
    }
}
