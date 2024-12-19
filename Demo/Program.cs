namespace Demo{	internal class Program	{


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
		static void PrintShap(int Nunber,string patter="/+*/")		{			for (int i = 0; i <= Nunber; i++)			{				Console.WriteLine(patter);			}		}		static int SumNumber(int Number01, int Number02)
		{ 		  return (Number01 + Number02);		}		static void Main(string[] args)		{			#region One D Array			//int[] Numbers;			//Numbers = new int[5];			//Numbers[0] = 12;			//Numbers[1] = 6;			//Numbers[2] = 16;			//Numbers[3] = 18;			//Numbers[4] = 19;			//// Numbers[5] = 20; Out Of Range			//Console.WriteLine(Numbers[0]);			//Console.WriteLine(Numbers[1]);			//Console.WriteLine(Numbers[2]);			//Console.WriteLine(Numbers[3]);			//Console.WriteLine(Numbers[4]);			//int[] Numbers01 = { 1, 2, 2, 4, 8, 4 };			//int[] Numbers02 = new int[5] { 1, 2, 3, 4, 5 };			//int[] Numbers03 = new int[] { 5, 6, 3, 8, 8, 7 };			//Console.Write("Enter The Nunber[0] ");			//int.TryParse(Console.ReadLine(), out Numbers[0]);			//for(int i =0;i<Numbers.Length;i++)			//{			//    Console.Write($"Enter The Numbers[{i}] ");			//    int.TryParse(Console.ReadLine(), out Numbers[i]);			//}			//Console.WriteLine("****************");			//for (int i = 0; i < Numbers.Length; i++)			//{			//    Console.Write($"{Numbers[i]} "  );			//}			//Console.WriteLine(Numbers.Length);			//Console.WriteLine(Numbers.Rank); 			#endregion			#region Two D Array			//int[,] Marks = new int[3, 3];			//Marks[0, 0] = 1;			//Marks[0, 1] = 5;			//Marks[0, 2] = 7;			//Marks[1, 0] = 11;			//Marks[1, 1] = 15;			//Marks[1, 2] = 17;			//Marks[2, 0] = 82;			//Marks[2, 1] = 62;			//Marks[2, 2] = 12;			//Console.WriteLine(Marks[1, 0] );			//Console.WriteLine(Marks[1, 1] );			//for(int i=0;i<3;i++)			//{			//    for(int j=0; j<3;j++)			//    {			//        Console.Write($"Enter Marks[{i},{j}] ");			//        int.TryParse(Console.ReadLine(),out Marks[i,j]);			//    }			//}			//for (int i = 0; i < 3; i++)			//{			//    for (int j = 0; j < 3; j++)			//    {			//        Console.Write($"{Marks[i,j]} ");			//    }			//    Console.WriteLine();			//}			#endregion			#region Two D Array (Juddge)			//int[][] Marks = new int[3][];			//Marks[0] = new int[] { 1, 2 };			//Marks[1] = new int[] { 1, 2, 3 };			//Marks[2] = new int[] { 1, 2, 3, 4 };			//Marks[0] = new int[3];			//Marks[1] = new int[2];			//Marks[2]= new int[5];			//for (int i=0;i<3;i++)			//{			//    for(int j = 0; j < Marks[i].Length;j++)			//    {			//        Console.Write($"Marks[{i}][{j}] ");			//        int.TryParse(Console.ReadLine(), out Marks[i][j]);  			//    }			//}			//Console.WriteLine();			//for (int i = 0; i < 3; i++)			//{			//    for (int j = 0; j < Marks[i].Length; i++)			//    {			//        Console.Write($"{Marks[i][j]} ");			//    }			//} 			#endregion			//PrintShap();			//PrintShap(5);			//PrintShap(5,"*/*");			Console.Write(SumNumber(5,6));		}	}}