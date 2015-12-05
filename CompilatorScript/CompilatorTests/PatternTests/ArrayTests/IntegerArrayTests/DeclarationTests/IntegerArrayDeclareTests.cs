namespace CompilatorTests.PatternTests.ArrayTests.IntegerArrayTests.DeclarationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IntegerArrayDeclareTests
    {
        [TestMethod]
        public void Test_Integer_Array_Declare_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_ARRAY_DECLARE_PATTERN);

            string testInput = "integer[] array";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for integer array declare without semicolon has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Array_Declare_Without_Array_Scopes()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_ARRAY_DECLARE_PATTERN);

            string testInput = "integer array;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for integer array declare without array scopes has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Array_Declare_With_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_ARRAY_DECLARE_PATTERN);

            string testInput = "integer[] array = new integer[5];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for integer array declare with initialisation has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Array_Declare_With_Incorrect_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_ARRAY_DECLARE_PATTERN);

            string testInput = "integer[] arra#y;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for integer array declare with incorrect name has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Array_Declare_With_Invalid_Type()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_ARRAY_DECLARE_PATTERN);

            string testInput = "boolean[] array;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for integer array declare with invalid type has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Array_Declare_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_ARRAY_DECLARE_PATTERN);

            string testInput = "integer[] array;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The final test for integer array declare has failed miserably.";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
