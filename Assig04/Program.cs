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








        }
    }
}
