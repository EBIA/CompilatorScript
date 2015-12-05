namespace CompilatorTests.PatternTests.VariableTests.BooleanTests.DeclarationAndInitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BooleanDeclareAndInitialiseTests
    {
        [TestMethod]
        public void Test_Boolean_Declare_And_Init_Pattern_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_DECLARE_AND_INIT_PATTERN);

            string testInput = "boolean testVar = true";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for boolean declaration and initialisation without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Boolean_Declare_And_Init_Pattern_Without_Value()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_DECLARE_AND_INIT_PATTERN);

            string testInput = "boolean testVar = ;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for boolean declaration and initialisation without value has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Boolean_Declare_And_Init_Pattern_With_Incorrect_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_DECLARE_AND_INIT_PATTERN);

            string testInput = "boolean testV#ar = false;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for boolean declaration and initialisation with incorrect name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Boolean_Declare_And_Init_Pattern_With_Incorrect_Type_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_DECLARE_AND_INIT_PATTERN);

            string testInput = "integer testVar = false;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for boolean declaration and initialisation with incorrect type declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Boolean_Declare_And_Init_Pattern_With_Incorrect_Type_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_DECLARE_AND_INIT_PATTERN);

            string testInput = "boolean testVar = \"this is bullshit\";";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for boolean declaration and initialisation with incorrect type initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Boolean_Declare_And_Init_Pattern_With_Missing_Equality_Symbol()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_DECLARE_AND_INIT_PATTERN);

            string testInput = "boolean testVar true;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for boolean declaration and initialisation with missing equality symbol has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Boolean_Declare_And_Init_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.BOOLEAN_DECLARE_AND_INIT_PATTERN);

            string testInput = "boolean testVar = true;"; 
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The final test for boolean declaration and initialisation has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
