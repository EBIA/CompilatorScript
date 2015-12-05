using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilatorScript
{
    using CompilatorScript.Core;

    class Program
    {
        private static void Main(string[] args)
        {
            // InputReader.ReadInput();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("void Main()");
            sb.AppendLine("{");
            sb.AppendLine("    integer a;");
            sb.AppendLine("    string asdsd;");
            sb.AppendLine("    a = 2;");
            sb.AppendLine("    asdsd = \"TUPO\";");
            sb.AppendLine("    if(a == 5)");
            sb.AppendLine("    {");
            sb.AppendLine("        Print(a);");
            sb.AppendLine("        for(asd;asd;asd)");
            sb.AppendLine("        {");
            sb.AppendLine("            integer Nanyo;");
            sb.AppendLine("        }");
            sb.AppendLine("        integer b = 10;");
            sb.AppendLine("        Print(b);");
            sb.AppendLine("        Print(asdsd);");
            sb.AppendLine("    }");
            sb.AppendLine("    integer asd = 1;");
            sb.AppendLine("}");

            List<string> codeText = sb.ToString().Split('\n').ToList();
            codeText.RemoveAll(s => s.Length < 1);

            CodeProcessor.ProcessCode(codeText);

        }
    }
}
