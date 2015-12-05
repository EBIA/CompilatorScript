namespace CompilatorTests.PatternTests.ArrayTests.StringArrayTests.DeclarationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StringArrayDeclareTests
    {
        [TestMethod]
        public void Test_String_Array_Declare_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_ARRAY_DECLARE_PATTERN);

            string testInput = "string[] array";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for string array declare without semicolon has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Array_Declare_Without_Array_Scopes()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_ARRAY_DECLARE_PATTERN);

            string testInput = "string array;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for string array declare without array scopes has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Array_Declare_With_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_ARRAY_DECLARE_PATTERN);

            string testInput = "string[] array = new string[5];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for string array declare with initialisation has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Array_Declare_With_Incorrect_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_ARRAY_DECLARE_PATTERN);

            string testInput = "string[] arra#y;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for string array declare with incorrect name has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Array_Declare_With_Invalid_Type()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_ARRAY_DECLARE_PATTERN);

            string testInput = "integer[] array;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for string array declare with invalid type has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_String_Array_Declare_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.STRING_ARRAY_DECLARE_PATTERN);

            string testInput = "string[] array;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The final test for string array declare has failed miserably.";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
