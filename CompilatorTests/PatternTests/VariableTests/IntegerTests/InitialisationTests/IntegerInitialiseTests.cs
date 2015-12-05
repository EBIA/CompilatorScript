namespace CompilatorTests.PatternTests.VariableTests.IntegerTests.InitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IntegerInitialiseTests
    {
        [TestMethod]
        public void Test_Integer_Init_Pattern_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_INIT_PATTERN);

            string testInput = "testVar = 5";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for integer initialisation without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }


        [TestMethod]
        public void Test_Integer_Init_Pattern_With_Invalid_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_INIT_PATTERN);

            string testInput = "testV#ar = 5;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for integer initialisation with invalid name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Init_Pattern_With_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_INIT_PATTERN);

            string testInput = "integer testVar = 23;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for integer initialisation with declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Init_Pattern_With_Incorrect_Type_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_INIT_PATTERN);

            string testInput = "testVar = 5.5;";
            bool testResult = testRegex.IsMatch(testInput);
            string testErrorMessage = "The test for integer initialisation with incorrect type initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Init_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_INIT_PATTERN);

            string testInput = "testVar = 3;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The final test for integer initialisation has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
