using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilatorScript.Core
{
    using System.Text.RegularExpressions;

    public static class CodeProcessor
    {
        private static List<Variable<object>> variables = new List<Variable<object>>();

        /// <summary>
        /// Overall Code Processor.
        /// </summary>
        /// <param name="receivedCode"></param>
        public static void ProcessCode(List<string> receivedCode)
        {
            if (receivedCode.Count == 0)
            {
                Console.WriteLine("Code Processed Successfully !");

                var test = variables;

                //foreach (var variable in variables)
                //{
                //    Console.WriteLine("#####VARIABLE#####\nName - {0};\nValue - {1};\nType - {2};\n", variable.GetName(), variable.Value, variable.Type);
                //}

                return;
            }

            try
            {
                string line = receivedCode.First();
                CodeDistributor(receivedCode, line);

                ProcessCode(receivedCode);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Distributes the line into corresponding processor depending on the line content.
        /// </summary>
        /// <param name="receivedCode"></param>
        /// <param name="line"></param>
        private static void CodeDistributor(List<string> receivedCode, string line)
        {
            string codeLine = line.Trim();

            //IF STATEMENT
            if (codeLine.Contains("if"))
            {
                ValidateIf(codeLine);
                receivedCode.Remove(line);

                var currentLines = ExtractStructureCode(receivedCode);
                ProcessIf(currentLines);
                return;
            }

            //FOR LOOP      
            if (codeLine.Contains("for"))
            {
                receivedCode.Remove(line);
                return;
            }

            if (codeLine.Contains("Print"))
            {
                ProcessPrint(codeLine);
                receivedCode.Remove(line);
                return;
            }
                
            //DECLARATION AND INITIALISATION OF VARIABLES
            if (ProcessDeclaration(codeLine) || ProcessInitialisation(codeLine)
                || ProcessDeclarationAndInitialisation(codeLine))
            {
                receivedCode.Remove(line);
                return;
            }

            int lineIndex = receivedCode.IndexOf(line);
            receivedCode.Remove(line);
            throw new NotSupportedException(string.Format("Incorrect line syntax on line - {0}", lineIndex));
        }

        /// <summary>
        /// Processor for declaration of variables.
        /// </summary>
        /// <param name="codeLine"></param>
        /// <returns></returns>
        private static bool ProcessDeclaration(string codeLine)
        {
            //DECLARATION PATTERNS
            Regex INTEGER_DECLARE_PATTERN = new Regex(RegexPatterns.INTEGER_DECLARE_PATTERN);

            Regex STRING_DECLARE_PATTERN = new Regex(RegexPatterns.STRING_DECLARE_PATTERN);

            Regex CHAR_DECLARE_PATTERN = new Regex(RegexPatterns.CHARACTER_DECLARE_PATTERN);

            Regex DOUBLE_DECLARE_PATTERN = new Regex(RegexPatterns.DOUBLE_DECLARE_PATTERN);

            Regex BOOLEAN_DECLARE_PATTERN = new Regex(RegexPatterns.BOOLEAN_DECLARE_PATTERN);

            var lineArguments = codeLine.Split(new[] { ' ', '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (INTEGER_DECLARE_PATTERN.IsMatch(codeLine))
            {
                var defaultValue = default(int);
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, defaultValue, false));
                return true;
            }

            if (STRING_DECLARE_PATTERN.IsMatch(codeLine))
            {
                var defaultValue = string.Empty;
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, defaultValue, false));
                return true;
            }

            if (CHAR_DECLARE_PATTERN.IsMatch(codeLine))
            {
                var defaultValue = default(char);
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, defaultValue, false));
                return true;
            }

            if (DOUBLE_DECLARE_PATTERN.IsMatch(codeLine))
            {
                var defaultValue = default(double);
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, defaultValue, false));
                return true;
            }

            if (BOOLEAN_DECLARE_PATTERN.IsMatch(codeLine))
            {
                var defaultValue = default(bool);
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, defaultValue, false));
                return true;
            }

            return false;
        }

        /// <summary>
        /// Processor for initialisation of variables.
        /// </summary>
        /// <param name="codeLine"></param>
        /// <returns></returns>
        private static bool ProcessInitialisation(string codeLine)
        {

            //INITIALISATION PATTERNS
            Regex INTEGER_INIT_PATTERN = new Regex(RegexPatterns.INTEGER_INIT_PATTERN);

            Regex STRING_INIT_PATTERN = new Regex(RegexPatterns.STRING_INIT_PATTERN);

            Regex CHAR_INIT_PATTERN = new Regex(RegexPatterns.CHARACTER_INIT_PATTERN);

            Regex DOUBLE_INIT_PATTERN = new Regex(RegexPatterns.DOUBLE_INIT_PATTERN);

            Regex BOOLEAN_INIT_PATTERN = new Regex(RegexPatterns.BOOLEAN_INIT_PATTERN);

            var lineArguments = codeLine.Split(new[] { ' ', '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (INTEGER_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = int.Parse(lineArguments[2]);
                var variableName = lineArguments[0];

                if (variables.Any(v => v.GetName() == variableName))
                {
                    variables.First(v => v.GetName() == variableName).SetValue(value);
                }
                else
                {
                    throw new ArgumentException("Non-existant variable");
                }

                return true;
            }

            if (STRING_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = lineArguments[2];
                var variableName = lineArguments[0];

                if (variables.Any(v => v.GetName() == variableName))
                {
                    variables.First(v => v.GetName() == variableName).SetValue(value);
                }
                else
                {
                    throw new ArgumentException("Non-existant variable");
                }

                return true;
            }

            if (CHAR_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = char.Parse(lineArguments[2]);
                var variableName = lineArguments[0];

                if (variables.Any(v => v.GetName() == variableName))
                {
                    variables.First(v => v.GetName() == variableName).SetValue(value);
                }
                else
                {
                    throw new ArgumentException("Non-existant variable");
                }

                return true;
            }

            if (DOUBLE_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = double.Parse(lineArguments[2]);
                var variableName = lineArguments[0];

                if (variables.Any(v => v.GetName() == variableName))
                {
                    variables.First(v => v.GetName() == variableName).SetValue(value);
                }
                else
                {
                    throw new ArgumentException("Non-existant variable");
                }

                return true;
            }

            if (BOOLEAN_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = lineArguments[2];
                var variableName = lineArguments[0];

                if (variables.Any(v => v.GetName() == variableName))
                {
                    variables.First(v => v.GetName() == variableName).SetValue(value);
                }
                else
                {
                    throw new ArgumentException("Non-existant variable");
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Processor for declaration and initialisation of variables (on one line).
        /// </summary>
        /// <param name="codeLine"></param>
        /// <returns></returns>
        private static bool ProcessDeclarationAndInitialisation(string codeLine)
        {

            //DECLARATION AND INITIALISATION (ON ONE LINE) PATTERNS
            Regex INTEGER_DECLARE_AND_INIT_PATTERN = new Regex(RegexPatterns.INTEGER_DECLARE_AND_INIT_PATTERN);

            Regex STRING_DECLARE_AND_INIT_PATTERN = new Regex(RegexPatterns.STRING_DECLARE_AND_INIT_PATTERN);

            Regex CHAR_DECLARE_AND_INIT_PATTERN = new Regex(RegexPatterns.CHARACTER_DECLARE_AND_INIT_PATTERN);

            Regex DOUBLE_DECLARE_AND_INIT_PATTERN = new Regex(RegexPatterns.DOUBLE_DECLARE_AND_INIT_PATTERN);

            Regex BOOLEAN_DECLARE_AND_INIT_PATTERN = new Regex(RegexPatterns.BOOLEAN_DECLARE_AND_INIT_PATTERN);

            var lineArguments = codeLine.Split(new[] { ' ', '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (INTEGER_DECLARE_AND_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = int.Parse(lineArguments[3]);
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, value, true));
                return true;
            }

            if (STRING_DECLARE_AND_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = lineArguments[3];
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, value, true));
                return true;
            }

            if (CHAR_DECLARE_AND_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = char.Parse(lineArguments[3]);
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, value, true));
                return true;
            }

            if (DOUBLE_DECLARE_AND_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = double.Parse(lineArguments[3]);
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, value, true));
                return true;
            }

            if (BOOLEAN_DECLARE_AND_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = bool.Parse(lineArguments[3]);
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, value, true));
                return true;
            }

            return false;
        }

        /// <summary>
        /// Process If Statement
        /// </summary>
        /// <param name="receivedCode"></param>
        private static void ProcessIf(List<string> receivedCode)
        {
            if (receivedCode.Count == 0)
            {
                return;
            }

            string line = receivedCode.First();
            CodeDistributor(receivedCode, line);


            ProcessIf(receivedCode);
        }


        private static bool ValidateIf(string codeLine)
        {
            //VARIABLE VS NUMBER PATTERN : if[\s]*\([\s]*[\w]+[\s]*(>=|<=|==)[\s]*[\d]*?\.?[\d]+[\s]*\)

            //VARIABLE VS STRING PATTERN : if[\s]*\([\s]*[\w]+[\s]*(>=|<=|==)[\s]*\".*\"[\s]*\)

            //VARIABLE VS CHAR PATTERN : if[\s]*\([\s]*[\w]+[\s]*(>=|<=|==)[\s]*\'.{1}\'[\s]*\)

            //VARIABLE VS BOOLEAN PATTERN : if[\s]*\([\s]*[\w]+[\s]*(>=|<=|==)[\s]*(true|false)[\s]*\)

            //NUMBER VS NUMBER : if[\s]*\([\s]*[\d]*?\.?[\d]+[\s]*(>=|<=|==)[\s]*[\d]*?\.?[\d]+[\s]*\)

            string[] arguments = codeLine.Split(new[] { ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            string firstValue = arguments[1];
            string condition = arguments[2];
            string secondValue = arguments[3];
            if (variables.Any(v => v.GetName().Equals(firstValue)))
            {
    
            }

            return false;
        }

        /// <summary>
        /// Processor for Print command.
        /// </summary>
        /// <param name="codeLine"></param>
        private static void ProcessPrint(string codeLine)
        {
            string[] arguments = codeLine.Split(new[] { ' ', '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string toPrint = arguments[1];
            if (toPrint.Contains("\""))
            {
                Console.WriteLine(toPrint);
            }
            else
            {
                if (!variables.Any(v => v.GetName().Equals(toPrint)))
                {
                    throw new InvalidOperationException("Unexistant variable.");
                }

                Console.WriteLine(variables.First(v => v.GetName().Equals(toPrint)).Value);
            }
        }

        /// <summary>
        /// Extract all lines of the current structure.
        /// </summary>
        /// <param name="receivedCode"></param>
        /// <returns></returns>
        private static List<string> ExtractStructureCode(List<string> receivedCode)
        {
            List<string> currentLines = new List<string>();
            int closingScopeIndex = 0;
            for (int i = 0; i < receivedCode.Count; i++)
            {
                if (receivedCode[i].Contains("}") && closingScopeIndex == 1)
                {
                    receivedCode.Remove(receivedCode[i]);
                    break;
                }

                if (receivedCode[i].Contains("}") && closingScopeIndex > 0)
                {
                    closingScopeIndex--;
                    receivedCode.Remove(receivedCode[i]);
                    i--;
                    continue;
                }

                if (receivedCode[i].Contains("{"))
                {
                    closingScopeIndex++;
                    receivedCode.Remove(receivedCode[i]);
                    i--;
                    continue;
                }

                currentLines.Add(receivedCode[i]);
                receivedCode.Remove(receivedCode[i]);
                i--;

                // End of extraction.
            }

            return currentLines;
        }
    }
}
