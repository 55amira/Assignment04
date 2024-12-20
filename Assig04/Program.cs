namespace Assig04
{
    internal class Program
    {
        

        
        static void Main(string[] args)
        {
            #region Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            //Passing By value

            //static void SAWP(int Number01, int Number02)
            //{
            //    int Temp;
            //    Temp = Number01;
            //    Number01 = Number02;
            //    Number02 = Temp;
            //}

            //int A = 5, B = 4;
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //Console.WriteLine("-------------------");
            //SAWP(A, B);
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            ////Passing By Reference

            //static void SAWP(ref int Number01, ref int Number02)
            //{
            //    int Temp;
            //    Temp = Number01;
            //    Number01 = Number02;
            //    Number02 = Temp;
            //}
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //Console.WriteLine("-------------------");
            //SAWP(ref A,ref B);
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            #endregion

            #region Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            //passing By value

            //static int SumArray(int[] Arr)
            //{
            //    int Sum = 0;
            //    Arr[0] = 100;
            //    for (int i = 0; i < Arr.Length; i++)
            //    {
            //        Sum += Arr[i];
            //    }
            //    return Sum;
            //}

            //int[] Numbers = { 1, 2, 3 };
            //int Sum = SumArray(Numbers);    
            //Console.WriteLine(Sum);
            //Console.WriteLine(Numbers[0]);

            //Passing By Reference
            //static int SumArray(ref int[] Arr)
            //{
            //    int Sum = 0;
            //    Arr = new int[] { 4, 5, 6 };
            //    for (int i = 0; i < Arr.Length; i++)
            //    {
            //        Sum += Arr[i];
            //    }
            //    return Sum;
            //}
            //int[] Numbers = { 1, 2, 3 };
            //int Sum = SumArray(ref Numbers);
            //Console.WriteLine(Sum);
            //Console.WriteLine(Numbers[0]);
            #endregion

            #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //static void SumSub(int Number01, int Number02, out int Sum, out int Sub)
            //{
            //    Sum = Number01 + Number02;
            //    Sub = Number01 - Number02;
            //}

            //Console.WriteLine("Enter Number 1 And Number 2 ");
            //int.TryParse(Console.ReadLine(),out int Number01);
            //int.TryParse(Console.ReadLine(), out int Number02);

            //SumSub(Number01,Number02,out int Sum,out int Sub);

            //Console.WriteLine($"Sum = {Sum} ");
            //Console.WriteLine($"Sub = {Sub} ");
            #endregion

            #region Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
            //static int SumDigits(int Number)
            //{
            //    string Digits = Number.ToString();
            //    int Sum = 0;
            //    for (int i = 0; i < Digits.Length; i++)
            //    {
            //        Sum += Convert.ToInt32(Digits.Substring(i, 1));
            //    }
            //    return Sum;
            //}
            //  Console.WriteLine(SumDigits(55));
            #endregion


            #region Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //static bool IsPrime(int Number)
            //{
            //    bool Flage = false;
            //    for (int i = 2; i <= Number; i++)
            //    {
            //        if (Number % i == 0)
            //        {
            //            Flage = false;

            //        }
            //        else
            //            Flage = true;

            //    }
            //    return Flage;

            //}

            //int Number = 8;
            //Console.WriteLine(IsPrime(Number));

            #endregion

            #region Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //static void MinMaxArray(int[] Arr ,ref int Max,ref int Min )
            //{
            //     Max=Arr[0];
            //     Min=Arr[0];

            //    for(int i=1;i<Arr.Length;i++)
            //    {

            //        if (Arr[i]>Max)
            //        { 
            //            Max=Arr[i];
            //        }
            //        else if (Arr[i] < Max)
            //        {
            //            Min=Arr[i];
            //        }
            //    }
            //}
            //int[] Numbers = { 1, 5, 8, 4, 66, -1 };
            //int Max=0, Min=0;
            //MinMaxArray( Numbers,ref  Max,ref Min);
            //Console.WriteLine(Max);
            //Console.WriteLine(Min); 
            #endregion

            #region Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //static int FactorialNumber(int Num)
            //{
            //    int Result = 1;
            //    for (int i =2;i<Num;i++)
            //    {
            //        Result *= i;
            //    }

            //    return Result;
            //}
            //Console.WriteLine(FactorialNumber(5));
            #endregion

            #region Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            //static void ChangeChar(ref string Word, int Pos,Char NewChar)
            //{
            //    //Word.Remove(Pos,1);
            //    //Word.Insert(Pos, NewChar.ToString());

            //    Word = Word.Substring(0, Pos) + NewChar + Word.Substring(Pos + 1);

            //}

            //string Word = "Amira";

            //ChangeChar(ref Word , 1, 'X');
            //Console.WriteLine(Word);
            #endregion

            #region  Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //static void Matrix(int Num)
            //{
            //    int[,] Numbers = new int[Num,Num];
            //    for(int i=0;i<Num;i++)
            //    {
            //        for (int j=0;j<Num;j++)
            //        {
            //            Console.Write($"Numbers[{i},{j}] = ");
            //            int.TryParse(Console.ReadLine(), out Numbers[i,j]);
            //        }
            //    }

            //    for (int i = 0; i < Num; i++)
            //    {
            //        for (int j = 0; j < Num; j++)
            //        {
            //            Console.Write($"{Numbers[i,j]} ");

            //        }
            //        Console.WriteLine();    
            //    }
            //}


            //Console.WriteLine("Enter Size Of Matrix : ");
            //int.TryParse(Console.ReadLine(), out int Size);

            //Matrix(Size); 
            #endregion

            #region Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] Numbers = { 1, 5, 4, 30 };

            //int Sum = 0;
            //for (int i = 0; i < Numbers.Length; i++)
            //{

            //    Sum += Numbers[i];

            //}

            //Console.WriteLine(Sum);

            #endregion


            #region  Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.


            //int[] Arr1 = { 5, 6, 8 };
            //int[] Arr2 = { 3, 7, 10 };
            //int[] Arr3 = new int[Arr1.Length + Arr2.Length];

            //int i = 0, j = 0, k = 0;

            //while (i < Arr1.Length && j < Arr2.Length)
            //{
            //    if (Arr1[i] < Arr2[j])
            //    {
            //        Arr3[k++] = Arr1[i++];
            //    }
            //    else
            //    {
            //        Arr3[k++] = Arr2[j++];
            //    }

            //}

            //while (i < Arr1.Length)
            //{
            //    Arr3[k++] = Arr1[i++];
            //}

            //while (j < Arr2.Length)
            //{
            //    Arr3[k++] = Arr2[j++];
            //}

            //for (int x = 0; x < Arr3.Length; x++)
            //{
            //    Console.Write($"{Arr3[x]} ");
            //}
            #endregion

            #region  Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] Numbers = { 2, 1, 5, 2, 2, 1, 5, 4, 6, 4, 5};

            //for (int i=0;i<Numbers.Length;i++)
            //{
            //    int count = 0;
            //    for(int j=0;j<Numbers.Length;j++)
            //    {
            //        if(Numbers[j] == Numbers[i])
            //            count++;
            //    }
            //    Console.WriteLine($"{Numbers[i]}  Count = {count} ");
            //}


            #endregion

            #region  Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] Array = { 1, 55, 22, 33, 77, 1001 };
            //int Max = Array[0];
            //int Min = Array[0];
            //for (int i = 1; i < Array.Length; i++)
            //{
            //    if (Array[i]>Max)
            //        Max = Array[i];
            //    else
            //        Min = Array[i];
            //}
            //Console.WriteLine(Max);
            //Console.WriteLine(Min);
            #endregion


            #region Write a program in C# Sharp to find the second largest element in an array.


            //int[] array = { 1, 55, 22, 33, 77, 1001 };
            //int max1 = array[0];
            //int max2 = array[0];
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > max1)
            //        max1 = array[i];
            //}
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > max2 && array[i]<max1)
            //        max2 = array[i];
            //}
            //Console.WriteLine(max2); 
            #endregion


            #region Write a Program to Print One Dimensional Array in Reverse Order
            //int[] Arr = { 1, 2, 3, 4 };
            //for (int i=Arr.Length-1; i>=0; i--)
            //{
            //    Console.Write($"{Arr[i]} ");
            //} 
            #endregion

            #region  Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array.
            //Console.Write("Enter The Number Of Rows : ");
            //int.TryParse(Console.ReadLine(), out int Rows);

            //Console.Write("Enter The Number Of Cols : ");
            //int.TryParse(Console.ReadLine(), out int Cols);

            //int[,] Arr1= new int[Rows, Cols];
            //int[,] Arr2= new int[Rows, Cols];


            //for (int i = 0; i < Rows; i++)
            //{
            //    for (int j = 0; j < Cols; j++)
            //    {
            //        Console.Write($"Enter Array1[{i},{j}] ");
            //        int.TryParse(Console.ReadLine(), out Arr1[i, j]);
            //    }
            //}

            //for (int i = 0; i < Rows; i++)
            //{
            //    for (int j = 0; j < Cols; j++)
            //    {
            //        Arr2[i,j]= Arr1[i, j];
            //    }
            //}

            //for (int i = 0; i < Rows; i++)
            //{
            //    for (int j = 0; j < Cols; j++)
            //    {
            //        Console.Write($"{Arr2[i, j]} ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region  Consider an Array of Integer values with size N, having values as in this Example   



            //Console.Write("Enter Size Of Array : ");
            //int.TryParse(Console.ReadLine(), out int Size);

            //int[] Numbers = new int[Size];
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.Write($"Enter The Numbers[{i}] ");
            //    int.TryParse(Console.ReadLine(), out Numbers[i]);

            //}
            //int MaxDistance=0;
            //for(int i = 0;i < Numbers.Length;i++)
            //{
            //    for(int j = Numbers.Length-1;j>0;j--)
            //    {
            //        int Distance = 0;
            //        if (Numbers[i] == Numbers[j])
            //        {
            //            Distance = j-i;
            //            if (Distance > MaxDistance)
            //            {
            //                MaxDistance = Distance;

            //            }
            //            break;
            //        }

            //    }
            //}
            //Console.WriteLine(MaxDistance); 
            #endregion

        }
    }
}
