namespace CompilatorTests.PatternTests.VariableTests.DoubleTests.DeclarationAndInitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DoubleDeclareAndInitialiseTests
    {
        [TestMethod]
        public void Test_Double_Declare_And_Init_Pattern_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_DECLARE_AND_INIT_PATTERN);

            string testInput = "double testVar = 5.5";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for double declaration and initialisation without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Declare_And_Init_Pattern_Without_Value()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_DECLARE_AND_INIT_PATTERN);

            string testInput = "double testVar = ;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for double declaration and initialisation without value has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Declare_And_Init_Pattern_With_Incorrect_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_DECLARE_AND_INIT_PATTERN);

            string testInput = "double testV#ar = 5.2;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for double declaration and initialisation with incorrect name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Declare_And_Init_Pattern_With_Incorrect_Type_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_DECLARE_AND_INIT_PATTERN);

            string testInput = "string testVar = 12.78;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for double declaration and initialisation with incorrect type declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Declare_And_Init_Pattern_With_Incorrect_Type_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_DECLARE_AND_INIT_PATTERN);

            string testInput = "double testVar = \"broken\";";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for double declaration and initialisation with incorrect type initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Declare_And_Init_Pattern_With_Missing_Equality_Symbol()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_DECLARE_AND_INIT_PATTERN);

            string testInput = "double testVar 12.5;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for double declaration and initialisation with missing equality symbol has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Declare_And_Init_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_DECLARE_AND_INIT_PATTERN);

            string firstTestInput = "double testVar = 12;";
            string secondTestInput = "double testVar = 33.45;"; 
            bool testResult = testRegex.IsMatch(firstTestInput);
            bool secondTestResult = testRegex.IsMatch(secondTestInput);

            string testErrorMessage = "The final test for double declaration and initialisation has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
            Assert.IsTrue(secondTestResult, testErrorMessage);
        }
    }
}
