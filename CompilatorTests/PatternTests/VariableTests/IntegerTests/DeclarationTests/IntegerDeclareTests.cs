namespace CompilatorTests.PatternTests.VariableTests.IntegerTests.DeclarationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IntegerDeclareTests
    {
        [TestMethod]
        public void Test_Integer_Declare_Pattern_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_DECLARE_PATTERN);

            string testInput = "integer testVar";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for integer declaration without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Declare_Pattern_With_Invalid_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_DECLARE_PATTERN);

            string testInput = "integer testV#ar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for integer declaration with invalid name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Declare_Pattern_With_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_DECLARE_PATTERN);

            string testInput = "integer testVar = 2;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for integer declaration with initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Declare_Pattern_With_Incorrect_Type_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_DECLARE_PATTERN);

            string testInput = "intege testVar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for integer declaration with incorrect type declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Declare_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_DECLARE_PATTERN);

            string testInput = "integer testVar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The final test for integer declaration has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
