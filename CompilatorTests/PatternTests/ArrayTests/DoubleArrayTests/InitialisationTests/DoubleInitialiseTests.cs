namespace CompilatorTests.PatternTests.ArrayTests.DoubleArrayTests.InitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DoubleInitialiseTests
    {
        [TestMethod]
        public void Test_Double_Array_Initialise_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_INIT_PATTERN);

            string testInput = "array = new double[5]";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array initialise without semicolon has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Initialise_Without_Array_Length()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_INIT_PATTERN);

            string testInput = "array = new double[];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array initialise without array length has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Initialise_With_Declaration()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_INIT_PATTERN);

            string testInput = "double[] array = new double[5];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array initialise with declaration has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Initialise_With_Incorrect_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_INIT_PATTERN);

            string testInput = "arra#y = new double[5];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array initialise with incorrect name has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Initialise_With_Invalid_Type()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_INIT_PATTERN);

            string testInput = "array = new character[4];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array initialise with invalid type has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Initialise_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_INIT_PATTERN);

            string testInput = "array = new double[5];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The final test for double array initialise has failed miserably.";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
