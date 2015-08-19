using System;
using System.Text;

class PersianRugs
{
    static void Main()
    {
        const char Blank = '.';
        const char Full = '#';
        const char Ex = 'X';
        const char LeftSym = '\\';
        const char RightSym = '/';


        int size = Int32.Parse(Console.ReadLine());
        int div = Int32.Parse(Console.ReadLine());

        for (int row = 0; row < 2 * size + 1; row++)
        {
            for (int column = 0; column < 2 * size + 1; column++)
            {

                if (column - row <= div / 2 && column - row >= -div / 2 ||
                    column + row <= 2 * size + div / 2 && column + row >= 2 * size - div / 2)
                {
                    Console.Write(Full);
                }
             
                if (column < row - (div / 2 + 1) && row < (2 * size - column) - (div / 2 + 1))
                {
                    Console.Write(Blank);
                }
             
                if (((column - row == div / 2 + 1) && (row < (size + 1 - div) || row > size)) ||
                    (column - row == -(div / 2 + 1) && (row < size || row > (size - 1 + div))))
                {
                    Console.Write(LeftSym);
                }                 

                if (row < column - (div / 2 + 1) && column < (2 * size - row) - (div / 2 + 1))                   
                {
                    Console.Write(Blank);
                }

                if ((column == size + div / 2 + 1 || column == size - (div / 2 + 1)) && row == size ||
                    (row == size + (div / 2 + 1) || row == size - (div / 2 + 1)) && column == size)
                {
                    Console.Write(Ex);
                }

                if (row > column + (div / 2 + 1) && row > (2 * size - column) + (div / 2 + 1))
                {
                    Console.Write(Blank);
                }

                if ((column + row == 2 * size + (div / 2 + 1) && (row < size || row > (size - 1 + div))) ||
                    (column + row == 2 * size - (div / 2 + 1) && (row < (size + 1 - div) || row > size)))
                {
                    Console.Write(RightSym);
                }

                if (column > row + (div / 2 + 1) && column > (2 * size - row) + (div / 2 + 1))
                {
                    Console.Write(Blank);
                }      

            }
            Console.WriteLine();
        }

    }
}

