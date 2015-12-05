namespace CompilatorTests.PatternTests.VariableTests.DoubleTests.DeclarationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DoubleDeclareTests
    {
        [TestMethod]
        public void Test_Double_Declare_Pattern_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_DECLARE_PATTERN);

            string testInput = "double testVar";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for double declaration without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Declare_Pattern_With_Invalid_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_DECLARE_PATTERN);

            string testInput = "double testV#ar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for double declaration with invalid name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Declare_Pattern_With_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_DECLARE_PATTERN);

            string testInput = "double testVar = 32.2;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for double declaration with initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Declare_Pattern_With_Incorrect_Type_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_DECLARE_PATTERN);

            string testInput = "doubl testVar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for double declaration with incorrect type declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Declare_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_DECLARE_PATTERN);

            string testInput = "double testVar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The final test for double declaration has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
