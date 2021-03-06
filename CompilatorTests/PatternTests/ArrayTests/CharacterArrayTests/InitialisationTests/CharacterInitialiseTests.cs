﻿namespace CompilatorTests.PatternTests.ArrayTests.CharacterArrayTests.InitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CharacterInitialiseTests
    {
        [TestMethod]
        public void Test_Character_Array_Initialise_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_ARRAY_INIT_PATTERN);

            string testInput = "array = new character[5]";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for character array initialise without semicolon has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Array_Initialise_Without_Array_Length()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_ARRAY_INIT_PATTERN);

            string testInput = "array = new character[];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for character array initialise without array length has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Array_Initialise_With_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_ARRAY_INIT_PATTERN);

            string testInput = "character[] array = new character[5];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for character array initialise with declaration has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Array_Initialise_With_Incorrect_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_ARRAY_INIT_PATTERN);

            string testInput = "arra#y = new character[5];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for character array initialise with incorrect name has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Array_Initialise_With_Invalid_Type()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_ARRAY_INIT_PATTERN);

            string testInput = "array = new string[4];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for character array initialise with invalid type has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Character_Array_Initialise_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.CHARACTER_ARRAY_INIT_PATTERN);

            string testInput = "array = new character[5];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The final test for character array initialise has failed miserably.";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
