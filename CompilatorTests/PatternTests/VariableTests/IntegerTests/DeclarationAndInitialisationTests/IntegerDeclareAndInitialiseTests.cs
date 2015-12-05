namespace CompilatorTests.PatternTests.VariableTests.IntegerTests.DeclarationAndInitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IntegerDeclareAndInitialiseTests
    {
        [TestMethod]
        public void Test_Integer_Declare_And_Init_Pattern_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_DECLARE_AND_INIT_PATTERN);

            string testInput = "integer testVar = 5";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for integer declaration and initialisation without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Declare_And_Init_Pattern_Without_Value()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_DECLARE_AND_INIT_PATTERN);

            string testInput = "integer testVar = ;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for integer declaration and initialisation without value has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Declare_And_Init_Pattern_With_Incorrect_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_DECLARE_AND_INIT_PATTERN);

            string testInput = "integer testV#ar = 5;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for integer declaration and initialisation with incorrect name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Declare_And_Init_Pattern_With_Incorrect_Type_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_DECLARE_AND_INIT_PATTERN);

            string testInput = "double testVar = 5;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for integer declaration and initialisation with incorrect type declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Declare_And_Init_Pattern_With_Incorrect_Type_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_DECLARE_AND_INIT_PATTERN);

            string testInput = "integer testVar = \"asd\";";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for integer declaration and initialisation with incorrect type initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Declare_And_Init_Pattern_With_Missing_Equality_Symbol()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_DECLARE_AND_INIT_PATTERN);

            string testInput = "integer testVar 5;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for integer declaration and initialisation with missing equality symbol has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Declare_And_Init_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_DECLARE_AND_INIT_PATTERN);

            string testInput = "integer testVar = 5;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The final test for integer declaration and initialisation has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
