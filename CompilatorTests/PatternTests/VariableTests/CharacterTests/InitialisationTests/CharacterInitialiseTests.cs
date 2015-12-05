namespace CompilatorTests.PatternTests.VariableTests.CharacterTests.InitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CharacterInitialiseTests
    {
        [TestMethod]
        public void Test_Character_Init_Pattern_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_INIT_PATTERN);

            string testInput = "testVar = \'t\'";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for character initialisation without semicolon has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }


        [TestMethod]
        public void Test_Character_Init_Pattern_With_Invalid_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_INIT_PATTERN);

            string testInput = "testV#ar = \'t\';";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for character initialisation with invalid name has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Init_Pattern_With_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_INIT_PATTERN);

            string testInput = "character testVar = \'t\';";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The test for character initialisation with declaration has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Init_Pattern_With_Incorrect_Type_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_INIT_PATTERN);

            string testInput = "testVar = 12;";
            bool testResult = testRegex.IsMatch(testInput);
            string testErrorMessage = "The test for character initialisation with incorrect type initialisation has failed miserably!";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Init_Pattern_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_INIT_PATTERN);

            string testInput = "testVar = \'t\';";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage = "The final test for character initialisation has failed miserably!";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
