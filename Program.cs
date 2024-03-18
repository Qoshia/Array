using System;

namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //for(int i = 0; i < studentScores.Length; i++)
    //    {
               // for(int j = 0; j < studentScores[i].Length; j++)
//                 {
//                         Console.Write(studentScores[i][j] + " ");
//                 }
//                 Console.WriteLine();
//         }

//         Console.Write("Enter the number of students that you wish to record their scores: ");
//         int noOfStudents = int.Parse(Console.ReadLine());
//         string[] studentNames = new string[noOfStudents];

//         int[][] sudentRecords = new int[noOfStudents][];

//         for(int i = 0; i < noOfStudents; i++)   
//         {
//                 Console.Write($"Enter the name of student {i + 1}: ");
//                 studentNames[i] = Console.ReadLine();

//                 Console.Write($"Enter the count of subjects for student {i + 1}: ");
//                 int countOfSubjects = int.Parse(Console.ReadLine());
//                 sudentRecords[i] = new int[countOfSubjects];
//                 for(int j = 0; j < countOfSubjects; j++)   
//                 {
//                         Console.Write($"Enter the score for subject {j + 1}: ");
//                         sudentRecords[i][j] = int.Parse(Console.ReadLine());
//                 }
//         }
//         //int sum = 0;

//         for(int i = 0; i < sudentRecords.Length; i++)
//         {
//                Console.WriteLine($"{studentNames[i]}: ");
//                 for(int j = 0; j < sudentRecords[i].Length; j++)
//                 {
//                         //sum += sudentRecords[i][j];
//                         Console.Write(sudentRecords[i][j] + " ");
//                 }
//                 Console.WriteLine()
//     
//int[][] a = new int[7][];    
        //for (int i = 7; i >=1; i--)
        // {
        //      for (int j = 0; j <=i - 1 ; j++)
        //       {
        //          Console.Write(j+" " );
             }Console.WriteLine();
        // }
        int[,] array = {{1,2,3,4} ,{5,6,7,8}, {9,10,11,12},{13,14,15,16}};
        int m = 0;
        int[] a =new int [16];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                a[m] =  array[i,j];
                m++;
                 
            }//Console.Write(a[m]); 
        }
        foreach (var item in a)
        {
            Console.Write(item);
        }

        }
    }
}
