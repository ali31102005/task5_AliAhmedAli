using System;
using System.Buffers.Text;
using System.ComponentModel.Design;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace ConsoleApp2
{




    class Program
    {


        enum DayOfWeek
        { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }


        #region p2
        public static void TestDegensiveCode()
        {
            int X, Y, Z;
            //bool flag;
            do
                Console.WriteLine("enter first positive number :");
            while (!int.TryParse(Console.ReadLine(), out X) || X < 0);
            do
                Console.WriteLine("enter second positive number :");
            while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);
            Z = X / Y;

            int[] arr = { 1, 2, 3, 4 };
            if (arr?.Length > 108)
                arr[108] = 78;
        }
        #endregion
     
        public static void fun(int n1, int n2, out int sum, out int pro)
        {
            sum = n1 + n2;
            pro = n1 * n2;
        }

        public static void fun2(string str, int r = 5)
        {
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine(str);
            }
        }


        public static int SumArr(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr?.Length; i++)
                sum += arr[i];
            return sum;
        }

        public static int pow(int n, int p)
        {
            if (p == 0) return 1;
            return n * pow(n, p - 1);
        }



        static void Main(string[] args)
        {

            #region p1
            //try
            //{
            //    Console.WriteLine("Enter first number: ");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter second number: ");
            //    int num2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"{num1}/{num2} = {num1 / num2}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //}

            #endregion

            #region p3

            //int[] arr = new int[3];
            //int? len = arr?.Length;

            //int? x = null;
            //Console.WriteLine((int)len);

            #endregion
            #region p4

            //int? x = null;
            //Console.WriteLine(x.Value);
            //int y = x ?? default;
            //Console.WriteLine(y);
            //x = 50;
            //y = x.HasValue? x.Value : 0;
            //Console.WriteLine(y);

            //Question: What exception occurs when trying to access Value on a null Nullable<T> ?
            //InvalidOpertionsException//NullReferenceException
            #endregion

            #region p5
            //try
            //{
            //int[] arr = { 1, 2, 3, 4, 5 };
            //    Console.WriteLine(arr[5]);
            //}
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion


            #region p6


            //int[,] arr = new int[2, 3];

            //for(int i = 0; i < arr.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter row{i+1}:");
            //    for(int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        do
            //        {
            //            Console.Write($"arr[{i},{j}] = ");
            //        } while (!int.TryParse(Console.ReadLine(), out arr[i, j]));

            //    }
            //}
            //int sum = 0;
            //Console.WriteLine("sum of elements in each row: ");
            //for(int i = 0; i<arr.GetLength(0); i++)
            //{
            //    for(int j = 0;j < arr.GetLength(1); j++)
            //    {
            //        sum += arr[i, j];
            //    }
            //    Console.WriteLine($"row{i + 1}: {sum}");
            //    sum = 0;
            //}
            //Console.WriteLine("sum of elements in each column: ");
            //for (int i = 0; i < arr.GetLength(1); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(0); j++)
            //    {
            //        sum += arr[j, i];
            //    }
            //    Console.WriteLine($"col{i + 1}: {sum}");
            //    sum = 0;
            //}

            #endregion


            #region p7

            //int[][] grades = new int[3][] { new int[3], new int[4], new int[5] };
            //bool T;
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.WriteLine($"Enter student{i + 1} grades:");
            //    for (int j = 0; j < grades[i].Length; j++)
            //    {
            //        do
            //        {
            //            Console.Write($"subject{j + 1}: ");
            //            T = int.TryParse(Console.ReadLine(), out int g);
            //            grades[i][j] = g;
            //            if (!T) Console.WriteLine("Error, invalid input.");
            //        } while (!T);
            //    }
            //}
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.WriteLine($"\nStudent{i + 1} grades:");
            //    for (int j = 0; j < grades[i].Length; j++)
            //    {
            //        Console.WriteLine($"subject{j + 1} : {grades[i][j]}");
            //    }
            //}
            #endregion


            #region p8
#nullable enable
            //string s = Console.ReadLine()!;

            //Console.WriteLine(s);

            #endregion

            #region p9
            //try
            //{

            //    object obj = 5; //boxing
            //    int x = (int)obj;//unboxing

            //}
            //catch(InvalidCastException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion


            #region p10
            //int sum, pro;
            //fun(5, 10, sum: out sum, out pro);

            //Console.WriteLine($"{sum}  {pro}");

            #endregion



            #region p11

            //fun2(str:"Ali", r:1);


            #endregion

            #region p12

            //int[] arr = { 1,2,3,4};

            //for (int i = 0; i < arr?.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            #endregion



            #region p13

            //Console.Write("Enter day name: ");

            //DayOfWeek d = (DayOfWeek) Enum.Parse(typeof(DayOfWeek), Console.ReadLine());

            //switch (d)
            //{
            //    case DayOfWeek.Monday:
            //        Console.WriteLine(DayOfWeek.Monday + " => " + ((int)DayOfWeek.Monday));
            //        break;
            //    case DayOfWeek.Tuesday:
            //        Console.WriteLine(DayOfWeek.Tuesday + " => " + ((int)DayOfWeek.Tuesday));
            //        break;
            //    case DayOfWeek.Wednesday:
            //        Console.WriteLine(DayOfWeek.Wednesday + " => " + ((int)DayOfWeek.Wednesday));
            //        break;
            //    case DayOfWeek.Thursday:
            //        Console.WriteLine(DayOfWeek.Thursday + " => " + ((int)DayOfWeek.Thursday));
            //        break;
            //    case DayOfWeek.Friday:
            //        Console.WriteLine(DayOfWeek.Friday + " => " + ((int)DayOfWeek.Friday));
            //        break;
            //    case DayOfWeek.Saturday:
            //        Console.WriteLine(DayOfWeek.Saturday + " => " + ((int)DayOfWeek.Saturday));
            //        break;
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine(DayOfWeek.Sunday + " => " + ((int)DayOfWeek.Sunday));
            //        break;
            //    default:
            //        Console.WriteLine("Unexpected day entered.");
            //        break;
            //}
            #endregion

            #region p14
            //int[] arr = { 1, 2, 3 };
            ////// 1
            //Console.WriteLine(SumArr(arr));
            //// 2 
            //Console.WriteLine(SumArr(1, 2, 6));
            #endregion


            #region p15

            //Console.Write("Enter num: ");
            //int c = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= c; i++)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region p16

            //Console.Write("Enter num: ");
            //int c = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i * c);
            //}


            #endregion


            #region p17

            //Console.Write("Enter num: ");
            //int c = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= c; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region p18


            //Console.Write("Enter num: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("Enter pow: ");
            //int p = int.Parse(Console.ReadLine());
            //int res = 1;
            //for (int i = 0; i < p; i++)
            //{
            //    res *= n;
            //}
            //Console.WriteLine($"result: {res}");

            //Console.WriteLine($"function result: {pow(n, p)}");

            #endregion

            #region p19
            //Console.Write("enter string: ");
            //StringBuilder s = new StringBuilder(Console.ReadLine());
            //int c = 1;
            //for (int i = 0; i < s.Length/2; i++)
            //{
            //    char temp = s[i];
            //    s[i] = s[s.Length-(i+1)];
            //    s[s.Length - (i+1)] = temp;
            //}
            //Console.WriteLine(s);
            #endregion

            #region p20

            //Console.Write("enter num: ");
            //int n = int.Parse(Console.ReadLine());
            //int RN = 0;
            //while(n > 0)
            //{
            //    RN *= 10;
            //    RN += n % 10;
            //    n /= 10;
            //}
            //Console.WriteLine($"reverse : {RN}");

            #endregion
            #region p21
            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //Console.WriteLine("Enter numbers: ");
            //for (int i = 0; i < arr?.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int dist = 0;
            //for (int i = 0; i < arr?.Length; i++)
            //{
            //    int d = 0;
            //    for (int j = i + 1; j < arr?.Length; j++)
            //    {
            //        d = arr[i] == arr[j] ? j - i - 1 : d;
            //    }
            //    if (d > dist)
            //    {
            //        dist = d;
            //    }
            //}
            //Console.WriteLine("Longest Distance Between Matching Elements: " + dist);
            #endregion


            #region p22

            //string s1 ="English is great";
            //string[] sarr = s1.Split(' ');
            //string s2 = "";

            //for(int i = sarr.Length - 1; i >= 0 ;i--)
            //{
            //    s2 += sarr[i] + (i > 0?" " : "");
            //}
            //Console.WriteLine(s2);



            #endregion




        }


    }


}
