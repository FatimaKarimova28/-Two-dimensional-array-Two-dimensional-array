
int number;
int sum = 0;
int[,] arr = new int[3, 3]
{
    {1, 2, 3},
    {4, 5, 6 },
    {7, 8, 9 }
};
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (i == j)
        {
            sum += arr[i, j];   
        }
     
      
    }
  
}
Console.WriteLine(sum);

//using System.Threading.Channels;

//int[,] arr  = new int[2, 2]
//{
//    {1, 2 },
//    {3, 4 }
//};

//int[,] arr2 = new int[2, 2]
//{
//    {5, 6 },
//    {7, 8 }
//};

//int[,] arr3 = new int[2, 2]
//{
//    {0, 0 },
//    {0, 0 }
//};

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        arr3[i, j] = arr[i, j] + arr2[i, j];
//        Console.Write(arr3[i, j] + " ");
//    }
//    Console.WriteLine();
//}




//int[,] arr = new int[5, 5]
//{
//    {1, 2, 3, 4, 5 },
//    {6, 7, 8, 9, 10 },
//    {11, 12, 13, 14, 15 },
//    {16, 17, 18, 19, 20 },
//    {21, 22, 23, 24, 25 }
//};
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        if (i > 3 - j)
//        {
//            arr[i, j] = 0;
//        }
//        Console.Write(arr[i, j] + " ");

//    }
//    Console.WriteLine();
//}