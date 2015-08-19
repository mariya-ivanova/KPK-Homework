using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class WalkInMatrix
    {
        private const int DirectionsCount = 8;
        private const int MinSize = 1;
        private const int MaxSize = 100;
        private int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

        private int size;
        private int[,] matrix;
        private int row = 0;
        private int col = 0;

        public WalkInMatrix(int size)
        {
            this.Size = size;
            this.matrix = new int[this.size, this.size];
            this.FindFreeCell();         
            this.FillFreeCells();
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value < MinSize || value > MaxSize)
                {
                    throw new ArgumentOutOfRangeException(string.Format(
                        "Size of the matrix must be in range [{0}...{1}]!", MinSize, MaxSize)
                        );
                }

                this.size = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringMatrix = new StringBuilder();

            for (int row = 0; row < this.size; row++)
            {
                for (int col = 0; col < this.size; col++)
                {
                    stringMatrix.AppendFormat("{0,3}", this.matrix[row, col]);
                }

                stringMatrix.Append("\r\n");
            }

            return stringMatrix.ToString();
        }

        private void changeDirection(ref int directionX, ref int directionY)
        {
            int currentDirection = 0;

            for (int directionIndex = 0; directionIndex < DirectionsCount; directionIndex++)
            {
                if (directionsX[directionIndex] == directionX && directionsY[directionIndex] == directionY)
                { 
                    currentDirection = directionIndex; 
                    break;
                } 
            }

            if (currentDirection == DirectionsCount - 1) 
            { 
                directionX = directionsX[0]; 
                directionY = directionsY[0]; 
                return;
            }

            directionX = directionsX[currentDirection + 1];
            directionY = directionsY[currentDirection + 1];
        }

        private bool IsCellFree(int row, int col)
        {
            int[] directionRow = new int[DirectionsCount];
            int[] directionCol = new int[DirectionsCount];
            Array.Copy(directionsX, directionRow, DirectionsCount);
            Array.Copy(directionsY, directionCol, DirectionsCount);

            int nextRow, nextCol;
            for (int directionIndex = 0; directionIndex < DirectionsCount; directionIndex++)
            {
                nextRow = row + directionRow[directionIndex];

                if (!this.IsInRange(nextRow))
                {
                    directionRow[directionIndex] = 0;
                    nextRow = row + directionRow[directionIndex];
                }

                nextCol = col + directionCol[directionIndex];

                if (!this.IsInRange(nextCol))
                {
                    directionCol[directionIndex] = 0;
                    nextCol = col + directionCol[directionIndex];
                }
           
                if (this.matrix[nextRow, nextCol] == 0)
                {
                    return true;
                }
            
            }

           return false;
        }

        private void FindFreeCell()
        {
            this.row = 0;
            this.col = 0;

            for (int currRow = 0; currRow < this.size; currRow++)
            {
                for (int currCol = 0; currCol < this.size; currCol++)
                {
                    if (this.matrix[currRow, currCol] == 0)
                    {
                        this.row = currRow;
                        this.col = currCol;
                        return;
                    }
                }
            }
        }

        private void FillFreeCells()
        {
            int directionRow = 1;
            int directionCol = 1;
            int cellValue = 1;

            while (true)
            {
                this.matrix[this.row, this.col] = cellValue;

                 if (!this.IsCellFree(this.row, this.col))
                {
                    this.FindFreeCell();

                    if (this.IsCellFree(this.row, this.col))
                    {
                        cellValue++;
                        this.matrix[this.row, this.col] = cellValue;
                        directionRow = 1;
                        directionCol = 1;
                    }
                    else
                    {
                        break;
                    }
                }

                int nextRow = this.row + directionRow;
                int nextCol = this.col + directionCol;

                if (!this.IsInRange(nextRow) || !this.IsInRange(nextCol) || this.matrix[nextRow, nextCol] != 0)
                {
                    while (!this.IsInRange(nextRow) || !this.IsInRange(nextCol) || this.matrix[nextRow, nextCol] != 0)
                    {
                        this.changeDirection(ref directionRow, ref directionCol);
                        nextRow = this.row + directionRow;
                        nextCol = this.col + directionCol;
                    }
                }

                this.row = nextRow;
                this.col = nextCol;
                cellValue++;
            }
        }

        private bool IsInRange(int value)
        {
            if (value >= this.size || value < 0)
            {
                return false;
            }

            return true;
        }
    }
}
