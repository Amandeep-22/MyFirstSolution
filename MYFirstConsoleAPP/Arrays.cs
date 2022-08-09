using System;


namespace MYFirstConsoleAPP
{
    internal class Arrays
    {
        static void Main()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0]= new int[3] {10,20,30};
            jaggedArray[1]= new int[5] {1,2,3,4,5};
            jaggedArray[2]= new int[4] {6,5,6,6};

           // jaggedArray[0][0] = 100;
          //  jaggedArray[0][1] = 200;
         /* for(int i=0;i<jaggedArray.Length;i++)
            {
                for(int j=0;j<jaggedArray[i].Length;j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }
         */
         foreach(int[] arr in jaggedArray)
            {
                foreach(int num in arr)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
