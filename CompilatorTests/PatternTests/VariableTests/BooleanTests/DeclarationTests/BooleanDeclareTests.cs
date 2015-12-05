namespace CompilatorTests.PatternTests.VariableTests.BooleanTests.DeclarationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BooleanDeclareTests
    {
        [TestMethod]
        public void Test_Boolean_Declare_Pattern_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_DECLARE_PATTERN);

            string testInput = "boolean testVar";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for boolean declaration without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Boolean_Declare_Pattern_With_Invalid_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_DECLARE_PATTERN);

            string testInput = "boolean testV#ar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for boolean declaration with invalid name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Boolean_Declare_Pattern_With_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_DECLARE_PATTERN);

            string testInput = "boolean testVar = false;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for boolean declaration with initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Boolean_Declare_Pattern_With_Incorrect_Type_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_DECLARE_PATTERN);

            string testInput = "bool testVar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for boolean declaration with incorrect type declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Boolean_Declare_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_DECLARE_PATTERN);

            string testInput = "boolean testVar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The final test for boolean declaration has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
