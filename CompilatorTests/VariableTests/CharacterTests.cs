using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompilatorTests.VariableTests
{
    using CompilatorScript;

    [TestClass]
    public class CharacterTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void Test_Character_Variable_Unassigned_Value()
        {
            Variable<char> testVar = new Variable<char>("testVar", default(char), false);
            char value = testVar.Value;
        }

        [TestMethod]
        public void Test_Character_Variable_Value_Get()
        {
            Variable<char> testVar = new Variable<char>("testVar", 'S', true);
            char value = testVar.Value;
            Assert.AreEqual('S', value, "Value getter does not work properly.<Character>");
        }

        [TestMethod]
        public void Test_Character_Variable_Value_Set()
        {
            Variable<char> testVar = new Variable<char>("testVar", default(char), false);
            testVar.SetValue('S');
            char value = testVar.Value;
            Assert.AreEqual('S', value, "Value setter does not work properly.<Character>");
        }

        [TestMethod]
        public void Test_Character_Variable_Addition_ToString()
        {
            Variable<char> testVar = new Variable<char>("testVar", 'S', true);
            Variable<char> testVar2 = new Variable<char>("testVar2", 'S', true);
                                                    
            Variable<string> resultVar = new Variable<string>("resultVar", testVar.Value.ToString() + testVar2.Value.ToString(), true);

            Assert.AreEqual("SS", resultVar.Value, "Addition(ToString) of two variables broken.<Character>");
        }

        [TestMethod]
        public void Test_Character_Variable_Addition_ToInteger()
        {
            Variable<char> testVar = new Variable<char>("testVar", 'S', true);
            Variable<char> testVar2 = new Variable<char>("testVar2", 'S', true);

            Variable<int> resultVar = new Variable<int>("resultVar", testVar.Value + testVar2.Value, true);

            Assert.AreEqual(166, resultVar.Value, "Addition(ToInteger) of two variables broken.<Character>");
        }
    }
}
