using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompilatorTests
{
    using CompilatorScript;

    [TestClass]
    public class IntegerTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void Test_Integer_Variable_Unassigned_Value()
        {
            Variable<int> testVar = new Variable<int>("testVar", default(int), false);
            int value = testVar.Value;
        }

        [TestMethod]
        public void Test_Integer_Variable_Value_Get()
        {
            Variable<int> testVar = new Variable<int>("testVar", 14, true);
            int value = testVar.Value;
            Assert.AreEqual(14, value, "Value getter does not work properly.<Integer>");
        }

        [TestMethod]
        public void Test_Integer_Variable_Value_Set()
        {
            Variable<int> testVar = new Variable<int>("testVar", default(int), false);
            testVar.SetValue(14);
            int value = testVar.Value;
            Assert.AreEqual(14, value, "Value setter does not work properly.<Integer>");    
        }

        [TestMethod]
        public void Test_Integer_Variable_Addition()
        {
            Variable<int> testVar = new Variable<int>("testVar", 14, true);
            Variable<int> testVar2 = new Variable<int>("testVar2", 14, true);
            
            Variable<int> resultVar = new Variable<int>("resultVar", testVar.Value + testVar2.Value, true);

            Assert.AreEqual(28, resultVar.Value, "Addition of two variables broken.<Integer>");
        }
    }
}
