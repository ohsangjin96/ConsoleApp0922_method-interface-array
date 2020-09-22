using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    class Array_1
    {
        static void CangeArray(int[] p)
        {
            p[0]++;
        }
        static int MyMax(int[] p) //Max를 구하는 로직
        {
            int max = p[0];
            for (int i=0; i<p.Length; i++)
            {
                if (p[i]>p[max])
                {
                    max = p[i];
                }
            }
            return max;
        }
        static void Main()
        {
            int[] arr1 = new int[3] { 1, 2, 3 };
            //Console.WriteLine(arr1[0]); //1
            //CangeArray(arr1);
            //Console.WriteLine(arr1[0]); //2

            int[] arr2 = new int[3] { 1, 2, 3 };//deep copy
            //Console.WriteLine(arr2[0]);  //1
            //CangeArray((int[])arr2.Clone());//object는 int[]으로 못바꾸기 때문에 형변환을 해야한다 ,Deep Copy
            //Console.WriteLine(arr2[0]); //1

            //Console.WriteLine(arr2.Min());
            //Console.WriteLine(arr2.Max());
            //Console.WriteLine(MyMax(arr2));

            int[] target = new int[5];// CopyTo,GetValue
            PrintArray(target);
            arr2.CopyTo(target, 0);
            PrintArray(target);
            Array.Copy(arr2, target, 3);
            PrintArray(target);

            int[] arr3 = new int[10] { 1, 5, 6, 2, 8, 9, 3, 4, 7, 0 };
            PrintArray(arr3);
            Array.Sort((int[])arr3.Clone());//sort한 후에도 그 배열을 유지하고 싶으면 Clone
            PrintArray(arr3);
            Array.Reverse(arr3);
            PrintArray(arr3);

            string str = "afdsgadgadgga"; //string은 원상태가 바뀌지 않는다.
            Console.WriteLine(str);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str);
            Console.WriteLine(str.Replace("gga","000000000000"));//->이렇게 해도 원본 str은 바뀌지 않는다.
            Console.WriteLine(str);

            str = str.Replace("gga", "000000000000");//값을 줘야한다.

            Console.WriteLine(str);

            int[,] s_arr = new int[2, 3] //2차배열은 행단위로 
            {
                {1,2,3},{4,5,6}
            };

            Console.WriteLine(s_arr[1,2]);

            PrintArray(s_arr);
         
        }

        private static void PrintArray(int[] target)//배열을 출력하는 메서드
        {
            for (int i = 0; i < target.Length; i++)
            {
                Console.Write(target.GetValue(i) + " ");
            }
            Console.WriteLine();
        }
        private static void PrintArray(int[,] target)//배열을 출력하는 메서드
        {
            for (int i = 0; i < target.GetLength(0); i++)
            {
                for (int k = 0; k < target.GetLength(1); k++)
                {
                    Console.Write(target[i, k] + " ");
                }
                Console.WriteLine();
            }

          
        }
    }
}
