namespace CompilatorTests.PatternTests.VariableTests.CharacterTests.DeclarationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CharacterDeclareTests
    {
        [TestMethod]
        public void Test_Character_Declare_Pattern_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_DECLARE_PATTERN);

            string testInput = "character testVar";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for character declaration without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Declare_Pattern_With_Invalid_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_DECLARE_PATTERN);

            string testInput = "character testV#ar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for character declaration with invalid name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Declare_Pattern_With_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_DECLARE_PATTERN);

            string testInput = "character testVar = \'t\';";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for character declaration with initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Declare_Pattern_With_Incorrect_Type_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_DECLARE_PATTERN);

            string testInput = "char testVar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for character declaration with incorrect type declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Declare_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_DECLARE_PATTERN);

            string testInput = "character testVar;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The final test for character declaration has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
