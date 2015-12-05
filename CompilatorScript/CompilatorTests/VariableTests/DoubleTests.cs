using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompilatorTests.VariableTests
{
    using CompilatorScript;

    [TestClass]
    public class DoubleTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethodAttribute]
        public void Test_Double_Variable_Unassigned_Value()
        {
            Variable<double> testVar = new Variable<double>("testVar", default(double), false);
            double value = testVar.Value;
        }

        [TestMethodAttribute]
        public void Test_Double_Variable_Value_Get()
        {
            Variable<double> testVar = new Variable<double>("testVar", 14.0, true);
            double value = testVar.Value;
            Assert.AreEqual(14, value, "Value getter does not work properly.<Double>");
        }

        [TestMethodAttribute]
        public void Test_Double_Variable_Value_Set()
        {
            Variable<double> testVar = new Variable<double>("testVar", default(double), false);
            testVar.SetValue(11.15623);
            double value = testVar.Value;
            Assert.AreEqual(11.15623, value, "Value setter does not work properly.<Double>");    
        }

        [TestMethodAttribute]
        public void Test_Double_Variable_Addition()
        {
            Variable<double> testVar = new Variable<double>("testVar", 12.3440348534, true);
            Variable<double> testVar2 = new Variable<double>("testVar2", 823.1057423699, true);
            
            Variable<double> resultVar = new Variable<double>("resultVar", testVar.Value + testVar2.Value, true);

            Assert.AreEqual(835.4497772233, resultVar.Value, "Addition of two variables broken.<Double>");
        }
    }
}
