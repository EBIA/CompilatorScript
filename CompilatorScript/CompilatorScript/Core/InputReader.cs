using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilatorScript
{
    public static class InputReader
    {
        public static void ReadInput()
        {
            string inputLine = Console.ReadLine();
            StringBuilder totalInput = new StringBuilder();

            int lineTabbing = 0;
            while (inputLine != "END")
            {
                totalInput.AppendLine(new string(' ', lineTabbing) + inputLine);
                if (inputLine.Contains("{"))
                {
                    string previousLine = new string(' ', lineTabbing) + inputLine;

                    string newLine;

                    if (inputLine.Length < 2)
                    {
                        newLine =
                        GetTabbing(lineTabbing, 1) +
                        "{";

                    }
                    else
                    {
                        newLine =
                        GetTabbing(lineTabbing, 1) +
                        inputLine.Substring(0, inputLine.Length - 1) +
                        "\n" +
                        GetTabbing(lineTabbing, 1) +
                        "{";
                    }

                    int index = totalInput.ToString().LastIndexOf(previousLine);
                    totalInput.Remove(index, previousLine.Length);
                    totalInput.Insert(index, newLine);
                    RefreshInput(totalInput);
                    lineTabbing += 4;
                }
                else if (inputLine.Contains("}"))
                {

                    string previousLine = new string(' ', lineTabbing) + inputLine;

                    string newLine;


                    if (inputLine.Length < 2)
                    {
                        newLine = GetTabbing(lineTabbing, -1) + "}";
                    }
                    else
                    {
                        newLine =
                        GetTabbing(lineTabbing, 1) +
                        inputLine.Substring(0, inputLine.Length - 1) +
                        "\n" +
                        GetTabbing(lineTabbing, -1) +
                        "}";
                    }

                    int index = totalInput.ToString().LastIndexOf(previousLine);
                    totalInput.Remove(index, previousLine.Length);
                    totalInput.Insert(index, newLine);
                    lineTabbing = lineTabbing > 0 ? lineTabbing - 4 : 0;
                    RefreshInput(totalInput);
                }

                Console.Write(new string(' ', lineTabbing));
                inputLine = Console.ReadLine();
            }
        }

        private static string GetTabbing(int tabbing, int func)
        {
            //If func == -1 get the decreasing 
            //else get the increasing
            switch (func)
            {
                case 1:
                    return new string(' ', tabbing);
                case -1:
                    if (tabbing == 0)
                    {
                        return new string(' ', tabbing);
                    }
                    return new string(' ', tabbing - 4);
            }

            return "Bullshit";
        }

        private static void RefreshInput(StringBuilder totalInput)
        {
            Console.Clear();
            Console.Write(totalInput);
        }
    }
}
