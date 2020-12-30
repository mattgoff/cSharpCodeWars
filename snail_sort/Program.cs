using System;

namespace snail_sort
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      int[][] array =
        {
           new []{1, 2, 3, 4},
           new []{5, 6, 7, 8},
           new []{9, 10, 11, 12},
           new int[]{13, 14, 15, 16}
       };
      var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
      var r2 = new[] { 1 ,2 ,3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10 };

      var actual = Snail(array);

    }


    public static int[] Snail(int[][] array)
    {
      int[] returnArray = new int[(array[0].Length * array.Length)];

        bool goingRight = true;
        bool goingDown = false;
        bool goingLeft = false;
        bool goingUp = false;

        int currentRow = 0;

        int topRowBound = 0;
        int bottomRowBound = array.Length;
        int leftColBound = 0;
        int rightColBound = array[0].Length;

        int moveCounter = 0;

        while(moveCounter < (array[0].Length * array.Length))
        {
            if (goingRight)
            {
                for(int i = leftColBound; i < rightColBound; i ++)
                {
                    System.Console.WriteLine($"{moveCounter} - {currentRow},{i} = {array[currentRow][i]}");
                    returnArray[moveCounter] = array[currentRow][i];
                    moveCounter++;
                }
                topRowBound++;
                currentRow++;

                goingRight = false;
                goingDown = true;
            }

            if (goingDown)
            {
                for(int i = currentRow; i < bottomRowBound; i++)
                {
                    System.Console.WriteLine($"{moveCounter} - {i},{rightColBound - 1} = {array[i][rightColBound - 1]}");
                    returnArray[moveCounter] = array[i][rightColBound - 1];
                    moveCounter++;
                }
                rightColBound --;
                currentRow = bottomRowBound;

                goingDown = false;
                goingLeft = true;
            }

            if (goingLeft)
            {
                for(int i = rightColBound - 1; i >= leftColBound; i --)
                {
                    System.Console.WriteLine($"{moveCounter} - {currentRow - 1},{i} = {array[currentRow - 1][i]}");
                    returnArray[moveCounter] = array[currentRow - 1][i];
                    moveCounter++;
                }
                bottomRowBound --;
                currentRow = topRowBound;

                goingLeft=false;
                goingUp=true;
            }

            if (goingUp)
            {
                for(int i = bottomRowBound - 1; i >= topRowBound; i--)
                {
                    System.Console.WriteLine($"{moveCounter} - {i},{leftColBound} = {array[i][leftColBound]}");
                    returnArray[moveCounter] = array[i][leftColBound];
                    moveCounter++;
                }

                leftColBound ++;

                goingUp = false;
                goingRight = true;
            }
        }
      return returnArray;
    }
  }
}