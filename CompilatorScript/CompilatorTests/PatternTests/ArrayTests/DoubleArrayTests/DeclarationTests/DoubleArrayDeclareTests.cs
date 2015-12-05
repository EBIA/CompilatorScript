namespace CompilatorTests.PatternTests.ArrayTests.DoubleArrayTests.DeclarationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DoubleArrayDeclareTests
    {
        [TestMethod]
        public void Test_Double_Array_Declare_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_DECLARE_PATTERN);

            string testInput = "double[] array";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array declare without semicolon has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Declare_Without_Array_Scopes()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_DECLARE_PATTERN);

            string testInput = "double array;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array declare without array scopes has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Declare_With_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_DECLARE_PATTERN);

            string testInput = "double[] array = new double[5];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array declare with initialisation has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Declare_With_Incorrect_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_DECLARE_PATTERN);

            string testInput = "double[] arra#y;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array declare with incorrect name has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Declare_With_Invalid_Type()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_DECLARE_PATTERN);

            string testInput = "string[] array;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array declare with invalid type has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Declare_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_DECLARE_PATTERN);

            string testInput = "double[] array;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The final test for double array declare has failed miserably.";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
