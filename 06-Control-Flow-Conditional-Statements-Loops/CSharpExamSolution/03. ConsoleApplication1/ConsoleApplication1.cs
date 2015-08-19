using System;

class ConsoleApplication1
{
    static void Main()
    {

        string inputSequence = "";
        string input = Console.ReadLine();
        while (!input.Equals("END"))
        {
            inputSequence += input + ",";
            input = Console.ReadLine();

        }

        string[] numbers = inputSequence.Split(',');
        int oddNumber = 0;
        int digit = 0;
        int product = 1;
        long productOfProducts = 1;
        long productOfProductsOver10 = 1;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (i < 10)
            {
                if (i % 2 != 0)
                {
                    oddNumber = Int32.Parse(numbers[i]);
                    product = 1;

                    while (oddNumber > 0)
                    {
                        digit = oddNumber % 10;
                        if (digit != 0)
                        {
                            product = product * digit;
                        }
                        oddNumber = oddNumber / 10;
                    }

                    productOfProducts *= product;
                }
            }

            else
            {
                if (i % 2 != 0)
                {
                    oddNumber = Int32.Parse(numbers[i]);
                    product = 1;

                    while (oddNumber > 0)
                    {
                        digit = oddNumber % 10;
                        if (digit != 0)
                        {
                            product = product * digit;
                        }
                        oddNumber = oddNumber / 10;
                    }

                    productOfProductsOver10 *= product;
                }
            }

        }

        Console.WriteLine(productOfProducts);
        if (numbers.Length > 10)
        {
            Console.WriteLine(productOfProductsOver10);
        }
    }
}

