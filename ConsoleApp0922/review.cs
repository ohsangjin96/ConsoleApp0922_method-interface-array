using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    class review
    {
        static void sqr(int x)
        {
            x = x * x;
        }
        static void sqr(ref int x)
        {
            x= x * x;
        }
        static void GetName(out string name,out int id)
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Id: " );
            id = int.Parse(Console.ReadLine());
        }
        static void PrintIntParams(params int[] arr)
        {
            for(int i =0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]+"");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int a = 3;
            sqr(a);
            Console.WriteLine("Vlue:{0}",a); //3, 만액 return x*x면 9

            int b = 3;
            sqr(ref b);
            Console.WriteLine("ref:{0}",b);//9

            string name;
            int id;
            GetName(out name, out id);
            Console.WriteLine("out:{0},{1}",name,id);

            PrintIntParams(1, 2, 3, 4);

            int[] myIntArray = { 5, 6, 7, 8, 9 };
            PrintIntParams(myIntArray);

            PrintIntParams();//params가 붙으면 안에 값을 안줘도 된다. 안에는 0만 나온다.

        }
    }
}
