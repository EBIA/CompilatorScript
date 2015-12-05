namespace CompilatorTests.PatternTests.ArrayTests.DoubleArrayTests.DeclarationAndInitialisationTests
{
    using System.Text.RegularExpressions;

    using CompilatorScript.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DoubleDeclareAndInitialiseTests
    {
        [TestMethod]
        public void Test_Double_Array_Declare_And_Initialise_Without_Semicolon()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_DECLARE_AND_INIT_PATTERN);

            string testInput = "double[] array = new double[4]";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array declare and initialise without semicolon has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Declare_And_Initialise_Without_Array_Length()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_DECLARE_AND_INIT_PATTERN);

            string testInput = "double[] array = new double[];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array declare and initialise without array length has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Declare_And_Initialise_Without_Equality_Symbol()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_DECLARE_AND_INIT_PATTERN);

            string testInput = "double[] array new double[4];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array declare and initialise without equality symbol has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Declare_And_Initialise_Without_Initialisation()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_DECLARE_AND_INIT_PATTERN);

            string testInput = "double[] array;";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array declare and initialise without initialisation has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Declare_And_Initialise_With_Incorrect_Name()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_DECLARE_AND_INIT_PATTERN);

            string testInput = "double[] arra#y = new double[4];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The test for double array declare and initialise with incorrect name has failed miserably.";
            Assert.IsFalse(testResult, testErrorMessage);
        }

        [TestMethod]
        public void Test_Double_Array_Declare_And_Initialise_Final()
        {
            Regex testRegex = new Regex(RegexPatterns.DOUBLE_ARRAY_DECLARE_AND_INIT_PATTERN);

            string testInput = "double[] array = new double[4];";
            bool testResult = testRegex.IsMatch(testInput);

            string testErrorMessage =
                "The final test for double array declare and initialise has failed miserably.";
            Assert.IsTrue(testResult, testErrorMessage);
        }
    }
}
