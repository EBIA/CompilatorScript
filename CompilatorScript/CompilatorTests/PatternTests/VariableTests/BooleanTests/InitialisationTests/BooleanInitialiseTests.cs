namespace CompilatorTests.PatternTests.VariableTests.BooleanTests.InitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BooleanInitialiseTests
    {
        [TestMethod]
        public void Test_Boolean_Init_Pattern_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_INIT_PATTERN);

            string testInput = "testVar = false";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for boolean initialisation without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }


        [TestMethod]
        public void Test_Boolean_Init_Pattern_With_Invalid_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_INIT_PATTERN);

            string testInput = "testV#ar = true";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for boolean initialisation with invalid name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Boolean_Init_Pattern_With_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_INIT_PATTERN);

            string testInput = "boolean testVar = false;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for boolean initialisation with declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Boolean_Init_Pattern_With_Incorrect_Type_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_INIT_PATTERN);

            string testInput = "testVar = 123;";
            bool testResult = testRegex.IsMatch(testInput);
            string testErrorMessage = "The test for boolean initialisation with incorrect type initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Boolean_Init_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_INIT_PATTERN);

            string testInput = "testVar = true;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The final test for boolean initialisation has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
