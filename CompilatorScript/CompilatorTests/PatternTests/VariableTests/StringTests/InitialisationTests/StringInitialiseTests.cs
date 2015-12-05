namespace CompilatorTests.PatternTests.VariableTests.StringTests.InitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StringInitialiseTests
    {
        [TestMethod]
        public void Test_String_Init_Pattern_Without_Semicolon()
        {
            int[] asd = new int[5];

            Regex testRegex = new Regex(RegexPatterns.STRING_INIT_PATTERN);

            string testInput = "testVar = \"test\"";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for string initialisation without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }


        [TestMethod]
        public void Test_String_Init_Pattern_With_Invalid_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_INIT_PATTERN);

            string testInput = "testV#ar = \"test\";";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for string initialisation with invalid name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Init_Pattern_With_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_INIT_PATTERN);

            string testInput = "string testVar = \"test\";";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for string initialisation with declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Init_Pattern_With_Incorrect_Type_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_INIT_PATTERN);

            string testInput = "testVar = \'t\';";
            bool testResult = testRegex.IsMatch(testInput);
            string testErrorMessage = "The test for string initialisation with incorrect type initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Init_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_INIT_PATTERN);

            string testInput = "testVar = \"test\";";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The final test for string initialisation has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
