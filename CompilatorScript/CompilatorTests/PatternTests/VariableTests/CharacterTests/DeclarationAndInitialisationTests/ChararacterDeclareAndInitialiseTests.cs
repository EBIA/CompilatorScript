namespace CompilatorTests.PatternTests.VariableTests.CharacterTests.DeclarationAndInitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CharacterDeclareAndInitialiseTests
    {
        [TestMethod]
        public void Test_Character_Declare_And_Init_Pattern_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_DECLARE_AND_INIT_PATTERN);

            string testInput = "character testVar = \'t\'";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for character declaration and initialisation without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Declare_And_Init_Pattern_Without_Value()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_DECLARE_AND_INIT_PATTERN);

            string testInput = "character testVar = ;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for character declaration and initialisation without value has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Declare_And_Init_Pattern_With_Incorrect_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_DECLARE_AND_INIT_PATTERN);

            string testInput = "character testV#ar = \'t\';";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for character declaration and initialisation with incorrect name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Declare_And_Init_Pattern_With_Incorrect_Type_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_DECLARE_AND_INIT_PATTERN);

            string testInput = "double testVar = \'t\';";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for character declaration and initialisation with incorrect type declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Declare_And_Init_Pattern_With_Incorrect_Type_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_DECLARE_AND_INIT_PATTERN);

            string testInput = "character testVar = true;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for character declaration and initialisation with incorrect type initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Declare_And_Init_Pattern_With_Missing_Equality_Symbol()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_DECLARE_AND_INIT_PATTERN);

            string testInput = "character testVar \'t\';";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for character declaration and initialisation with missing equality symbol has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Declare_And_Init_Pattern_Initialisation_With_Empty()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_DECLARE_AND_INIT_PATTERN);

            string testInput = "character testVar = \'\';";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for character declaration and initialisation with empty initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Declare_And_Init_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_DECLARE_AND_INIT_PATTERN);

            string testInput = "character testVar = \'t\';"; 
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The final test for character declaration and initialisation has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
