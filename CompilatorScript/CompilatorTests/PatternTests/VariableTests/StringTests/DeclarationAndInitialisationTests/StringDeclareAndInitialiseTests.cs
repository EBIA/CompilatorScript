namespace CompilatorTests.PatternTests.VariableTests.StringTests.DeclarationAndInitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StringDeclareAndInitialiseTests
    {
        [TestMethod]
        public void Test_String_Declare_And_Init_Pattern_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_DECLARE_AND_INIT_PATTERN);

            string testInput = "string testVar = \"test\"";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for string declaration and initialisation without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Declare_And_Init_Pattern_Without_Value()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_DECLARE_AND_INIT_PATTERN);

            string testInput = "string testVar = ;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for string declaration and initialisation without value has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Declare_And_Init_Pattern_With_Incorrect_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_DECLARE_AND_INIT_PATTERN);

            string testInput = "string testV#ar = \"test\";";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for string declaration and initialisation with incorrect name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Declare_And_Init_Pattern_With_Incorrect_Type_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_DECLARE_AND_INIT_PATTERN);

            string testInput = "boolean testVar = \"test\";";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for string declaration and initialisation with incorrect type declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Declare_And_Init_Pattern_With_Incorrect_Type_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_DECLARE_AND_INIT_PATTERN);

            string testInput = "string testVar = \'t\';";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for string declaration and initialisation with incorrect type initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Declare_And_Init_Pattern_With_Missing_Equality_Symbol()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_DECLARE_AND_INIT_PATTERN);

            string testInput = "string testVar \"test\";";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for string declaration and initialisation with missing equality symbol has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Declare_And_Init_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_DECLARE_AND_INIT_PATTERN);

            string testInputEmpty = "string testVar = \"\";";
            string testInput = "string testVar = \"th1s 15 a t3s7 #$!\";"; 
            bool testResult = testRegex.IsMatch(testInput);
            bool secondTestResult = testRegex.IsMatch(testInputEmpty);

            string testErrorMessage = "The final test for string declaration and initialisation has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
            Assert.IsTrue(secondTestResult, testErrorMessage);
        }
    }
}
