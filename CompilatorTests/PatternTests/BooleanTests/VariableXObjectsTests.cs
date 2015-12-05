namespace CompilatorTests.PatternTests.BooleanTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class VariableXObjectsTests
    {
        [TestMethod]
        public void Test_Varible_X_Number_Pattern()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_VALIDATE_VARIABLE_X_NUMBER_PATTERN);

            string firstTest = "      testVar     >=       23";
            string secondTest = "     testVar     ==       .2";
            string thirdTest = "      testVar     <=      0";
            string fourthTest = "     testVar     >       11.234";
            string fifthTest = "      testVar     <       56.0";

            bool firstResult = testRegex.IsMatch(firstTest);
            bool secondResult = testRegex.IsMatch(secondTest);
            bool thirdResult = testRegex.IsMatch(thirdTest);
            bool fourthResult = testRegex.IsMatch(fourthTest);
            bool fifthResult = testRegex.IsMatch(fifthTest);

            Assert.IsTrue(firstResult, "You Stupid Bitch !(1)");
            Assert.IsFalse(secondResult, "You Stupid Bitch !(2)");
            Assert.IsTrue(thirdResult, "You Stupid Bitch !(3)");
            Assert.IsTrue(fourthResult, "You Stupid Bitch !(4)");
            Assert.IsTrue(fifthResult, "You Stupid Bitch !(5)");
        }

        [TestMethod]
        public void Test_Varible_X_String_Pattern()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_VALIDATE_VARIABLE_X_STRING_PATTERN);

            string firstTest = "      testVar     >=       \"test\"";
            string secondTest = "     testVar     ==       \'t\'";
            string thirdTest = "      testVar     <=      \"\"";

            bool firstResult = testRegex.IsMatch(firstTest);
            bool secondResult = testRegex.IsMatch(secondTest);
            bool thirdResult = testRegex.IsMatch(thirdTest);

            Assert.IsTrue(firstResult, "You Stupid Bitch !(1)");
            Assert.IsFalse(secondResult, "You Stupid Bitch !(2)");
            Assert.IsTrue(thirdResult, "You Stupid Bitch !(3)");
        }

        public void Test_Varible_X_Character_Pattern()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_VALIDATE_VARIABLE_X_CHARACTER_PATTERN);

            string firstTest = "      testVar     >=       \'t\'";
            string secondTest = "     testVar     ==       \'te\'";
            string thirdTest = "      testVar     <=      \'\'";
            string fourthTest = "     testVar     >        \'#\'";
            string fifthTest = "      testVar     <        23";
            string sixthTest = "      testVar     ==       \"asd\"";

            bool firstResult = testRegex.IsMatch(firstTest);
            bool secondResult = testRegex.IsMatch(secondTest);
            bool thirdResult = testRegex.IsMatch(thirdTest);
            bool fourthResult = testRegex.IsMatch(fourthTest);
            bool fifthResult = testRegex.IsMatch(fifthTest);
            bool sixthResult = testRegex.IsMatch(sixthTest);


            Assert.IsTrue(firstResult, "You Stupid Bitch !(1)");
            Assert.IsTrue(secondResult, "You Stupid Bitch !(2)");
            Assert.IsFalse(thirdResult, "You Stupid Bitch !(3)");
            Assert.IsTrue(fourthResult, "You Stupid Bitch !(4)");
            Assert.IsFalse(fifthResult, "You Stupid Bitch !(5)");
            Assert.IsFalse(sixthResult, "You Stupid Bitch !(6)");
        }

        public void Test_Varible_X_Boolean_Pattern()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_VALIDATE_VARIABLE_X_BOOLEAN_PATTERN);

            string firstTest = "      testVar     ==       true";
            string secondTest = "     testVar     ==       12";
            string thirdTest = "      testVar     ==      \"\"";
            string fourthTest = "      testVar     >=       23.3";

            bool firstResult = testRegex.IsMatch(firstTest);
            bool secondResult = testRegex.IsMatch(secondTest);
            bool thirdResult = testRegex.IsMatch(thirdTest);
            bool fourthResult = testRegex.IsMatch(fourthTest);

            Assert.IsTrue(firstResult, "You Stupid Bitch !(1)");
            Assert.IsFalse(secondResult, "You Stupid Bitch !(2)");
            Assert.IsFalse(thirdResult, "You Stupid Bitch !(3)");
            Assert.IsFalse(fourthResult, "You Stupid Bitch !(4)");
        }
    }
}
