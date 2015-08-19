using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mines
{
    public class Minesweeper
    {  
        static void Main(string[] args)
        {
            const int FIELDS_IN_PLAYGROUND = 35;
            string command = string.Empty;
            char[,] playground = createPlayground();
            char[,] minesBoard = createMinesBoard();
            int counter = 0;
            bool stepOverMine = false;
            List<Score> champions = new List<Score>(6);
            int row = 0;
            int column = 0;
            bool startNewGame = true;
            bool gameWin = false;

            do
            {
                if (startNewGame)
                {
                    Console.WriteLine("Let's play “Mines”. Try your luck finding fields without mines." +
                    " Command 'top' shows ratings, 'restart' starts a new game, 'exit' exits game.");
                    dumpp(playground);
                    startNewGame = false;
                }
                Console.Write("Enter row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= playground.GetLength(0) && column <= playground.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        Ratings(champions);
                        break;
                    case "restart":
                        playground = createPlayground();
                        minesBoard = createMinesBoard();
                        dumpp(playground);
                        stepOverMine = false;
                        startNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye!");
                        break;
                    case "turn":
                        if (minesBoard[row, column] != '*')
                        {
                            if (minesBoard[row, column] == '-')
                            {
                                nextTurn(playground, minesBoard, row, column);
                                counter++;
                            }
                            if (FIELDS_IN_PLAYGROUND == counter)
                            {
                                gameWin = true;
                            }
                            else
                            {
                                dumpp(playground);
                            }
                        }
                        else
                        {
                            stepOverMine = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command.\n");
                        break;
                }

                if (stepOverMine)
                {
                    dumpp(minesBoard);
                    Console.Write("\nGame over! Your score is {0} points. " +
                        "Your name: ", counter);
                    string nickname = Console.ReadLine();
                    Score score = new Score(nickname, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(score);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < score.Points)
                            {
                                champions.Insert(i, score);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Score rating1, Score rating2) => rating2.Name.CompareTo(rating1.Name));
                    champions.Sort((Score rating1, Score rating2) => rating2.Points.CompareTo(rating1.Points));
                    Ratings(champions);

                    playground = createPlayground();
                    minesBoard = createMinesBoard();
                    counter = 0;
                    stepOverMine = false;
                    startNewGame = true;
                }
                if (gameWin)
                {
                    Console.WriteLine("\nCongratulations! You opened {0} cells without bombs to explode.",
                                      FIELDS_IN_PLAYGROUND);
                    dumpp(minesBoard);
                    Console.WriteLine("Your name: ");
                    string nickname = Console.ReadLine();
                    Score score = new Score(nickname, counter);
                    champions.Add(score);
                    Ratings(champions);
                    playground = createPlayground();
                    minesBoard = createMinesBoard();
                    counter = 0;
                    gameWin = false;
                    startNewGame = true;
                }
            }
            while (command != "exit");
              Console.WriteLine("Made in Bulgaria!");
        //    Console.WriteLine("Bye.");
        //    Console.Read();
        }

        private static void Ratings(List<Score> scores)
        {
            Console.WriteLine("\nPoints:");
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells",
                        i + 1, scores[i].Name, scores[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("List is empty!\n");
            }
        }

        private static void nextTurn(char[,] playground,
            char[,] bombs, int row, int column)
        {
            char mineMark = minesCount(bombs, row, column);
            bombs[row, column] = mineMark;
            playground[row, column] = mineMark;
        }

        private static void dumpp(char[,] playground)
        {
            int rows = playground.GetLength(0);
            int columns = playground.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);
                for (int column = 0; column < columns; column++)
                {
                    Console.Write(string.Format("{0} ", playground[row, column]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] createPlayground()
        {
            int rows = 5;
            int columns = 10;
            char[,] playground = new char[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    playground[row, column] = '?';
                }
            }

            return playground;
        }

        private static char[,] createMinesBoard()
        {
            int rows = 5;
            int columns = 10;
            char[,] minesBoard = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    minesBoard[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int nextMine = random.Next(50);
                if (!mines.Contains(nextMine))
                {
                    mines.Add(nextMine);
                }
            }

            foreach (int mine in mines)
            {
                int column = (mine / columns);
                int row = (mine % columns);
                if (row == 0 && mine != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }
                minesBoard[column, row - 1] = '*';
            }

            return minesBoard;
        }

        /*
        private static void calculations(char[,] playground)
        {
            int row = playground.GetLength(0);
            int column = playground.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (playground[i, j] != '*')
                    {
                        char mineMark = minesCount(playground, i, j);
                        playground[i, j] = mineMark;
                    }
                }
            }
        }
        */

        private static char minesCount(char[,] minesBoard, int row, int column)
        {
            int count = 0;
            int rows = minesBoard.GetLength(0);
            int columns = minesBoard.GetLength(1);

            if (row - 1 >= 0)
            {
                if (minesBoard[row - 1, column] == '*')
                {
                    count++;
                }
            }
            if (row + 1 < rows)
            {
                if (minesBoard[row + 1, column] == '*')
                {
                    count++;
                }
            }
            if (column - 1 >= 0)
            {
                if (minesBoard[row, column - 1] == '*')
                {
                    count++;
                }
            }
            if (column + 1 < columns)
            {
                if (minesBoard[row, column + 1] == '*')
                {
                    count++;
                }
            }
            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (minesBoard[row - 1, column - 1] == '*')
                {
                    count++;
                }
            }
            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (minesBoard[row - 1, column + 1] == '*')
                {
                    count++;
                }
            }
            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (minesBoard[row + 1, column - 1] == '*')
                {
                    count++;
                }
            }
            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (minesBoard[row + 1, column + 1] == '*')
                {
                    count++;
                }
            }
            return char.Parse(count.ToString());
        }
    }
}
