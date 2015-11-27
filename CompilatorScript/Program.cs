using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilatorScript
{
    using System.Threading;

    class Program
    {
        private static void Main(string[] args)
        {
            // InputReader.ReadInput();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("public static void Main()");
            sb.AppendLine("{");
            sb.AppendLine("    integer a;");
            sb.AppendLine("    string asdsd;");
            sb.AppendLine("    asdsd = \"TUPO\";");
            sb.AppendLine("    a = 5;");
            sb.AppendLine("    if(a == 5)");
            sb.AppendLine("    {");
            sb.AppendLine("        Print(a);");
            sb.AppendLine("        for(asd;asd;asd)");
            sb.AppendLine("        {");
            sb.AppendLine("            integer Nanyo;");
            sb.AppendLine("        }");
            sb.AppendLine("        integer b = 10;");
            sb.AppendLine("        Print(b);");
            sb.AppendLine("    }");
            sb.AppendLine("    integer asd = 1");
            sb.AppendLine("}");

            List<string> codeText = sb.ToString().Split('\n').ToList();
            codeText.RemoveAll(s => s.Length < 1);
            
            CodeProcessor.ProcessCode(codeText);

            //Variable<string> a = new Variable<string>("SomeVar", "Hello ");
            //Variable<string> b = new Variable<string>("SomeOtherVar", "World");

            //Console.WriteLine(a.GetValue().GetType().Name);

            //var asd = a + b;

            //Console.WriteLine(asd);
        }
    }
}
