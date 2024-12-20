namespace Assig04
{
    internal class Program
    {
        //static void SAWP(int Number01, int Number02)
        //{
        //    int Temp;
        //    Temp = Number01;
        //    Number01 = Number02;
        //    Number02 = Temp;
        //}

        static void SAWP(ref int Number01,ref int Number02)
        {
            int Temp;
            Temp = Number01;
            Number01 = Number02;
            Number02 = Temp;
        }
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
        static int SumArray(ref int[] Arr)
        {
            int Sum = 0;
            Arr=new int[] {4,5,6};
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }
        static void SumSub(int Number01, int Number02, out int Sum, out int Sub)
        {
            Sum = Number01 + Number02;
            Sub = Number01 - Number02;
        }
        static void Main(string[] args)
        {
            #region Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            //Passing By value
            //int A = 5, B = 4;
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //Console.WriteLine("-------------------");
            //SAWP(A, B);
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            ////Passing By Reference
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //Console.WriteLine("-------------------");
            //SAWP(ref A,ref B);
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            #endregion

            #region Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            //passing By value
            //int[] Numbers = { 1, 2, 3 };
            //int Sum = SumArray(Numbers);    
            //Console.WriteLine(Sum);
            //Console.WriteLine(Numbers[0]);

            //Passing By Reference
            //int[] Numbers = { 1, 2, 3 };
            //int Sum = SumArray(ref Numbers);
            //Console.WriteLine(Sum);
            //Console.WriteLine(Numbers[0]);
            #endregion

            #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //Console.WriteLine("Enter Number 1 And Number 2 ");
            //int.TryParse(Console.ReadLine(),out int Number01);
            //int.TryParse(Console.ReadLine(), out int Number02);

            //SumSub(Number01,Number02,out int Sum,out int Sub);

            //Console.WriteLine($"Sum = {Sum} ");
            //Console.WriteLine($"Sub = {Sub} ");
            #endregion

        }
    }
}
