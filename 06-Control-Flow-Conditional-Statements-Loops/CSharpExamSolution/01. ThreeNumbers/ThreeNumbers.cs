using System;

class ThreeNumbers
{
    static void Main()
    {
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        int c = Int32.Parse(Console.ReadLine());

        int max = a;
        int min = a;
        double mean = 0;

        if(b > max)
        {
           max = b;
        }

        if (c > max)
        {
            max = c;
        }

        if (b < min)
        {
            min = b;
        }

        if (c < min)
        {
            min = c;
        }

        mean = (double)(a + b + c) / 3;

        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine("{0:F2}", mean);

    }
}

