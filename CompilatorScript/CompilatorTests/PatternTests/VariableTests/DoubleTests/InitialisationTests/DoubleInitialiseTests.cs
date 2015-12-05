namespace CompilatorTests.PatternTests.VariableTests.DoubleTests.InitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DoubleInitialiseTests
    {
        [TestMethod]
        public void Test_Double_Init_Pattern_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_INIT_PATTERN);

            string testInput = "testVar = 5.5";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for double initialisation without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }


        [TestMethod]
        public void Test_Double_Init_Pattern_With_Invalid_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_INIT_PATTERN);

            string testInput = "testV#ar = 12.3";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for double initialisation with invalid name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Init_Pattern_With_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_INIT_PATTERN);

            string testInput = "double testVar = 5.5;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for double initialisation with declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Init_Pattern_With_Incorrect_Type_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_INIT_PATTERN);

            string testInput = "testVar = \"t\";";
            bool testResult = testRegex.IsMatch(testInput);
            string testErrorMessage = "The test for double initialisation with incorrect type initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Init_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_INIT_PATTERN);

            string testInput = "testVar = 12.2;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The final test for double initialisation has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
