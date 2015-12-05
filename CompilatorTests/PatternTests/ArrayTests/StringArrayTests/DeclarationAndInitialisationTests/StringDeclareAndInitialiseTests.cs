namespace CompilatorTests.PatternTests.ArrayTests.StringArrayTests.DeclarationAndInitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StringDeclareAndInitialiseTests
    {
        [TestMethod]
        public void Test_String_Array_Declare_And_Initialise_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_ARRAY_DECLARE_AND_INIT_PATTERN);

            string testInput = "string[] array = new string[4]";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for string array declare and initialise without semicolon has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Array_Declare_And_Initialise_Without_Array_Length()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_ARRAY_DECLARE_AND_INIT_PATTERN);

            string testInput = "string[] array = new string[];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for string array declare and initialise without array length has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Array_Declare_And_Initialise_Without_Equality_Symbol()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_ARRAY_DECLARE_AND_INIT_PATTERN);

            string testInput = "string[] array new string[4];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for string array declare and initialise without equality symbol has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Array_Declare_And_Initialise_Without_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_ARRAY_DECLARE_AND_INIT_PATTERN);

            string testInput = "string[] array;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for string array declare and initialise without initialisation has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Array_Declare_And_Initialise_With_Incorrect_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_ARRAY_DECLARE_AND_INIT_PATTERN);

            string testInput = "string[] arra#y = new string[4];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for string array declare and initialise with incorrect name has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Array_Declare_And_Initialise_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_ARRAY_DECLARE_AND_INIT_PATTERN);

            string testInput = "string[] array = new string[4];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The final test for string array declare and initialise has failed miserably.";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
