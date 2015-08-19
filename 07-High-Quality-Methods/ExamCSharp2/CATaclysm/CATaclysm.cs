using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class CATaclysm
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        StringBuilder code = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            string strLine = Console.ReadLine();
            code.Append(strLine);
        }

        string codeText = code.ToString();
        /*
        string patternType = @"\bsbyte\byte\short\b";

        foreach (Match m in Regex.Matches(codeText, patternType))
        {
            Console.WriteLine(m);
        }
        */

        string[] types = {"sbyte", "byte", "short", "ushort", "int", "uint", "long",
                             "ulong", "float", "double", "decimal", "bool", "char", "string"};

        int indexOfIf = codeText.IndexOf("if");
        int indexOfElse = codeText.IndexOf("else", indexOfIf);
        List<string> result = new List<string>();

        for (int i = indexOfIf; i < codeText.Length; i += indexOfElse)
        {
            string strInIF = codeText.Substring(indexOfIf, indexOfElse - indexOfIf);
            string[] keywords = strInIF.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < keywords.Length - 1; j++)
            {
                foreach (var type in types)
                    if (keywords[j] == type)
                        result.Add(keywords[i + 1]);
            }
        }

        string resultString = string.Join(", ", result);
        Console.WriteLine("Methods -> {var1, var2, var3}");
        Console.WriteLine("Loops -> {var1, var2, var3}");
        Console.WriteLine("Conditional Statements -> {{0}}", resultString);

    }
}

