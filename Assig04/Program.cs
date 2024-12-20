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
        }
    }
}
