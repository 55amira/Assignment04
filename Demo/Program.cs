namespace Demo{	internal class Program	{

        class NewData
        {
            public int Sum;
            public int Mul;
        }

		#region Function Prototype

		//static void PrintShap()
		//{ 
		//    for (int i=0;i<=5;i++)
		//    {
		//        Console.WriteLine("*-*");
		//    }

		//}

		//static void PrintShap(int Nunber)
		//{
		//    for (int i = 0; i <= Nunber; i++)
		//    {
		//        Console.WriteLine("*-*");
		//    }

		//} 
		#endregion
		//static void PrintShap(int Nunber,string patter="/+*/")		//{		//	for (int i = 0; i <= Nunber; i++)		//	{		//		Console.WriteLine(patter);		//	}		//}		static int SumNumber(int Number01, int Number02)
		{ 		  return (Number01 + Number02);		}

        //static void SWAP(int Number01, int Number02)
        //{
        //	int Temp;
        //	Temp = Number01;
        //	Number01= Number02;
        //	Number02 = Temp;
        //}

        //static void SWAP( ref int Number01, ref int  Number02)
        //{
        //    int Temp;
        //    Temp = Number01;
        //    Number01 = Number02;
        //    Number02 = Temp;
        //}

        //static int SumArray(int[] Arr)
        //{
        //	int Sum = 0;
        //	Arr[0] = 100;
        //	for (int i = 0; i < Arr.Length; i++)
        //	{
        //		Sum += Arr[i];
        //	}
        //	return Sum;
        //}

        //static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}

        //static int SumArray( int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr = new int[] { 4, 5, 6 };
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}

        static int SumArray(ref int[] Arr)
        {
            int Sum = 0;
            Arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }

        //static int[] SumMul(int X, int Y)
        //{
        //    int[] Result = new int[] { (X + Y), (X * Y) };
        //    return Result;
        //}

        //static NewData SumMul(int X, int Y)
        //{
        //    NewData Data = new NewData();
        //    Data.Sum = X + Y;
        //    Data.Mul = X*Y;
        //    return Data;
        //}

        static void SumMul(int X, int Y,out int Sum,out int Mul)
        {
            Sum = X + Y;
            Mul = X * Y;
        }
        static void Main(string[] args)		{















            #region One D Array            //int[] Numbers;
                                            //Numbers = new int[5];
                                            //Numbers[0] = 12;
                                            //Numbers[1] = 6;
                                            //Numbers[2] = 16;
                                            //Numbers[3] = 18;
                                            //Numbers[4] = 19;
                                            //// Numbers[5] = 20; Out Of Range

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //Console.WriteLine(Numbers[4]);


            //int[] Numbers01 = { 1, 2, 2, 4, 8, 4 };
            //int[] Numbers02 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] Numbers03 = new int[] { 5, 6, 3, 8, 8, 7 };

            //Console.Write("Enter The Nunber[0] ");
            //int.TryParse(Console.ReadLine(), out Numbers[0]);

            //for(int i =0;i<Numbers.Length;i++)
            //{
            //    Console.Write($"Enter The Numbers[{i}] ");
            //    int.TryParse(Console.ReadLine(), out Numbers[i]);

            //}
            //Console.WriteLine("****************");
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.Write($"{Numbers[i]} "  );
            //}

            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Rank); 
            #endregion
            #region Two D Array            //int[,] Marks = new int[3, 3];

            //Marks[0, 0] = 1;
            //Marks[0, 1] = 5;
            //Marks[0, 2] = 7;

            //Marks[1, 0] = 11;
            //Marks[1, 1] = 15;
            //Marks[1, 2] = 17;

            //Marks[2, 0] = 82;
            //Marks[2, 1] = 62;
            //Marks[2, 2] = 12;

            //Console.WriteLine(Marks[1, 0] );
            //Console.WriteLine(Marks[1, 1] );

            //for(int i=0;i<3;i++)
            //{
            //    for(int j=0; j<3;j++)
            //    {
            //        Console.Write($"Enter Marks[{i},{j}] ");
            //        int.TryParse(Console.ReadLine(),out Marks[i,j]);
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{Marks[i,j]} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Two D Array (Juddge)
            //int[][] Marks = new int[3][];
            //Marks[0] = new int[] { 1, 2 };
            //Marks[1] = new int[] { 1, 2, 3 };
            //Marks[2] = new int[] { 1, 2, 3, 4 };

            //Marks[0] = new int[3];
            //Marks[1] = new int[2];
            //Marks[2]= new int[5];


            //for (int i=0;i<3;i++)
            //{
            //    for(int j = 0; j < Marks[i].Length;j++)
            //    {
            //        Console.Write($"Marks[{i}][{j}] ");
            //        int.TryParse(Console.ReadLine(), out Marks[i][j]);  
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; i++)
            //    {
            //        Console.Write($"{Marks[i][j]} ");

            //    }
            //} 
            #endregion
            //PrintShap();
            //PrintShap(5);
            //PrintShap(5,"*/*");

            //Console.Write(SumNumber(5,6));

            #region Passing Parameter Value Type
            //int A, B;
            //A = 1;
            //B = 2;

            ////Passing By Value
            //         //Console.WriteLine($"A = {A} ");
            //         //Console.WriteLine($"B = {B} ");

            //         //Console.WriteLine("-----------");
            //         //SWAP(A, B);

            //         //         Console.WriteLine($"A = {A} ");
            //         //         Console.WriteLine($"B = {B} ");

            ////Passing By REF
            //         Console.WriteLine($"A = {A} ");
            //         Console.WriteLine($"B = {B} ");

            //         Console.WriteLine("-----------");
            //         SWAP(ref A,ref B);

            //         Console.WriteLine($"A = {A} ");
            //         Console.WriteLine($"B = {B} "); 
            #endregion
            #region Passing Parameter Reference Type
            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine(SumArray(Numbers));//Passing By Value
            //Console.WriteLine(Numbers[0]);

            //         Console.WriteLine(SumArray(ref Numbers));//Passing By ref
            //         Console.WriteLine(Numbers[0]); 

            #region Ex01
            ////int[] Numbers = { 1, 2, 3 };

            //////Console.WriteLine(SumArray(Numbers));
            //////Console.WriteLine(Numbers[0]);

            ////Console.WriteLine(SumArray(ref  Numbers));
            ////Console.WriteLine(Numbers[0]); 
            #endregion
            #endregion
            #region Output Prameter

            ////int A=5, B=6;
            ////int[] Result= SumMul(A, B);
            //// Console.WriteLine(Result[0]);
            //// Console.WriteLine(Result[1]);

            ////NewData Data = SumMul(A, B);

            ////Console.WriteLine(Data.Sum);
            ////Console.WriteLine(Data.Mul);    

            //int A = 5, B = 6,Sum,Mul;
            //SumMul(A,B,out Sum,out Mul);
            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul); 
            #endregion
        }
    }}