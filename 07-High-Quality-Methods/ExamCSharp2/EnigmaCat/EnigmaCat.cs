using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class EnigmaCat
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.ToLower();
        string[] words = input.Split(new char[] {' '});
        string[] result = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            result[i] = OneSystemToAnother(words[i], 17, 26);
        }

        string resultString = string.Join(" ", result);
        Console.WriteLine(resultString);
    }

    static string OneSystemToAnother(string number, int numeralSystem1, int numeralSystem2)
    {
        BigInteger temp = BaseToDecimal(number, numeralSystem1);
        string result = DecimalToBase(temp, numeralSystem2);
        return result;
    }

    static string DecimalToBase(BigInteger decimalNumber, int numeralSystem)
    {
        string result = "";
        while (decimalNumber > 0)
        {
            int digit = (int)(decimalNumber % numeralSystem);
            result = (char)(digit + 'a') + result;
            decimalNumber /= numeralSystem;
        }

        return result;
    }

    static BigInteger BaseToDecimal(string number, int numeralSystem)
    {
        BigInteger decimalNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            int digit = 0;

            if (number[i] >= 'a' /* && number[i] <= 'r' */)
            {
                digit = number[i] - 'a';
            }

            decimalNumber += (BigInteger)(digit * Math.Pow(numeralSystem, number.Length - i - 1));
        }

        return decimalNumber;
    }
}
