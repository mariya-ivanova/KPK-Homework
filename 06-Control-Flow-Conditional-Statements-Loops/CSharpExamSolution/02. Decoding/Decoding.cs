using System;

    class Decoding
    {
        static void Main()
        {
            int salt = Int32.Parse(Console.ReadLine());
            int chars = Console.Read();
            double a = 1; int i = 0;           

            while (chars != '@')
            {
                if (chars >= 65 && chars <= 90 || chars >= 97 && chars <= 122)
                {
                    a = chars * salt + 1000;
                }

                else if (chars >= 48 && chars <= 57)
                {
                    a = chars + salt + 500;
                }

                else 
                {
                    a = chars - salt;
                }

                if (i % 2 == 0)
                {
                    a = a / 100;
                    Console.WriteLine("{0:F2}", a);
                }

                else 
                {
                    a = a * 100;
                    Console.WriteLine(a);
                }

                i++;
                chars = Console.Read();
            }
        }
    }

