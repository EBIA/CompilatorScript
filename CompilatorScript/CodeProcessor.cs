using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilatorScript
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

                foreach (var variable in variables)
                {
                    Console.WriteLine("Name - {0};\nValue - {1};\nType - {2};", variable.Name, variable.Value, variable.Type);
                }

                return;
            }

            string line = receivedCode.First();
            CodeDistributor(receivedCode, line);

            ProcessCode(receivedCode);
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

            //DECLARATION AND INITIALISATION OF VARIABLES
            if (ProcessDeclaration(codeLine) || ProcessInitialisation(codeLine)
                || ProcessDeclarationAndInitialisation(codeLine))
            {
                receivedCode.Remove(line);
                return;
            }

            Console.WriteLine(line);
            receivedCode.Remove(line);
        }

        /// <summary>
        /// Processor for declaration of variables.
        /// </summary>
        /// <param name="codeLine"></param>
        /// <returns></returns>
        private static bool ProcessDeclaration(string codeLine)
        {

            //DECLARATION PATTERNS
            Regex INTEGER_DECLARE_PATTERN = new Regex("integer[\\s]+[\\w]+[\\s]*;");

            Regex STRING_DECLARE_PATTERN = new Regex("string[\\s]+[\\w]+[\\s]*;");

            Regex CHAR_DECLARE_PATTERN = new Regex("char[\\s]+[\\w]+[\\s]*;");

            Regex DOUBLE_DECLARE_PATTERN = new Regex("double[\\s]+[\\w]+[\\s]*;");

            var lineArguments = codeLine.Split(new[] { ' ', '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (INTEGER_DECLARE_PATTERN.IsMatch(codeLine))
            {
                var defaultValue = default(int);
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, defaultValue));
                return true;
            }

            if (STRING_DECLARE_PATTERN.IsMatch(codeLine))
            {
                var defaultValue = string.Empty;
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, defaultValue));
                return true;
            }

            if (CHAR_DECLARE_PATTERN.IsMatch(codeLine))
            {
                var defaultValue = default(char);
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, defaultValue));
                return true;
            }

            if (DOUBLE_DECLARE_PATTERN.IsMatch(codeLine))
            {
                var defaultValue = default(double);
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, defaultValue));
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
            Regex INTEGER_INIT_PATTERN = new Regex("^[\\w]+[\\s]+=[\\s]*[\\d]+[\\s]*;$");

            Regex STRING_INIT_PATTERN = new Regex("^[\\w]+[\\s]+=[\\s]*\".*\"+[\\s]*;$");

            Regex CHAR_INIT_PATTERN = new Regex("^[\\w]+[\\s]+=[\\s]*\'.{1}\'+[\\s]*;$");

            Regex DOUBLE_INIT_PATTERN = new Regex("^[\\w]+[\\s]+=[\\s]*[\\d]+?[.|,]?[\\d]+[\\s]*;$");

            var lineArguments = codeLine.Split(new[] { ' ', '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (INTEGER_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = int.Parse(lineArguments[2]);
                var variableName = lineArguments[0];

                if (variables.Any(v => v.Name == variableName))
                {
                    variables.First(v => v.Name == variableName).SetValue(value);
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

                if (variables.Any(v => v.Name == variableName))
                {
                    variables.First(v => v.Name == variableName).SetValue(value);
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

                if (variables.Any(v => v.Name == variableName))
                {
                    variables.First(v => v.Name == variableName).SetValue(value);
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

                if (variables.Any(v => v.Name == variableName))
                {
                    variables.First(v => v.Name == variableName).SetValue(value);
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
            Regex INTEGER_DECLARE_AND_INIT_PATTERN = new Regex("integer[\\s]+[\\w]+[\\s]+=[\\s]*[\\d]+[\\s]*;");

            Regex STRING_DECLARE_AND_INIT_PATTERN = new Regex("string[\\s]+[\\w]+[\\s]+=[\\s]*\".+\"[\\s]*;");

            Regex CHAR_DECLARE_AND_INIT_PATTERN = new Regex("char[\\s]+[\\w]+[\\s]+=[\\s]*\'.{1}\'[\\s]*;");

            Regex DOUBLE_DECLARE_AND_INIT_PATTERN = new Regex("double[\\s]+[\\w]+[\\s]+=[\\s]*[\\d]+?[.|,]?[\\d]+[\\s]*;");

            var lineArguments = codeLine.Split(new[] { ' ', '(', ')', ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (INTEGER_DECLARE_AND_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = int.Parse(lineArguments[3]);
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, value));
                return true;
            }

            if (STRING_DECLARE_AND_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = lineArguments[3];
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, value));
                return true;
            }

            if (CHAR_DECLARE_AND_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = char.Parse(lineArguments[3]);
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, value));
                return true;
            }

            if (DOUBLE_DECLARE_AND_INIT_PATTERN.IsMatch(codeLine))
            {
                var value = double.Parse(lineArguments[3]);
                var variableName = lineArguments[1];
                variables.Add(new Variable<object>(variableName, value));
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
