using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompilatorTests
{
    using CompilatorScript;

    [TestClass]
    public class StringTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void Test_String_Variable_Unassigned_Value()
        {
            Variable<string> testVar = new Variable<string>("testVar", string.Empty, false);
            string value = testVar.Value;
        }

        [TestMethod]
        public void Test_String_Variable_Value_Get()
        {
            Variable<string> testVar = new Variable<string>("testVar", string.Empty, true);
            string value = testVar.Value;
            Assert.AreEqual(string.Empty, value, "Value getter does not work properly.<String>");
        }

        [TestMethod]
        public void Test_String_Variable_Value_Set()
        {
            Variable<string> testVar = new Variable<string>("testVar", string.Empty, false);
            testVar.SetValue("Nanyo");
            string value = testVar.Value;
            Assert.AreEqual("Nanyo", value, "Value setter does not work properly.<String>");
        }

        [TestMethod]
        public void Test_String_Variable_Addition()
        {
            Variable<string> testVar = new Variable<string>("testVar", "Nanyo", true);
            Variable<string> testVar2 = new Variable<string>("testVar2", "Nanyov", true);

            Variable<string> resultVar = new Variable<string>("resultVar", testVar.Value + " " + testVar2.Value, true);

            Assert.AreEqual("Nanyo Nanyov", resultVar.Value, "Addition of two variables broken.<String>");
        }
    }
}
