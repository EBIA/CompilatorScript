namespace CompilatorTests.PatternTests.ArrayTests.IntegerArrayTests.InitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IntegerInitialiseTests
    {
        [TestMethod]
        public void Test_Integer_Array_Initialise_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_ARRAY_INIT_PATTERN);

            string testInput = "array = new integer[5]";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for integer array initialise without semicolon has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Array_Initialise_Without_Array_Length()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_ARRAY_INIT_PATTERN);

            string testInput = "array = new integer[];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for integer array initialise without array length has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Array_Initialise_With_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_ARRAY_INIT_PATTERN);

            string testInput = "integer[] array = new integer[5];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for integer array initialise with declaration has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Array_Initialise_With_Incorrect_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_ARRAY_INIT_PATTERN);

            string testInput = "arra#y = new integer[5];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for integer array initialise with incorrect name has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Array_Initialise_With_Invalid_Type()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_ARRAY_INIT_PATTERN);

            string testInput = "array = new boolean[4];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for integer array initialise with invalid type has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Integer_Array_Initialise_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.INTEGER_ARRAY_INIT_PATTERN);

            string testInput = "array = new integer[5];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The final test for integer array initialise has failed miserably.";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
