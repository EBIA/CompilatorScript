namespace CompilatorTests.PatternTests.VariableTests.StringTests.DeclarationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StringDeclareTests
    {
        [TestMethod]
        public void Test_String_Declare_Pattern_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_DECLARE_PATTERN);

            string testInput = "string testVar";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for string declaration without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Declare_Pattern_With_Invalid_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_DECLARE_PATTERN);

            string testInput = "string testV#ar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for string declaration with invalid name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Declare_Pattern_With_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_DECLARE_PATTERN);

            string testInput = "string testVar = \"test\";";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for string declaration with initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Declare_Pattern_With_Incorrect_Type_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_DECLARE_PATTERN);

            string testInput = "stri testVar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for string declaration with incorrect type declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Declare_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_DECLARE_PATTERN);

            string testInput = "string testVar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The final test for string declaration has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
