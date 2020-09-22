using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    class Method_1
    {
        static void Sum(int step,int start=1,int end=100)//기본값을 안준것이 필수 값을 준것은 선택(선택보다 필수가 앞에 와야한다)
        {
            int sum = 0;
            for(int i=start; i<=end; i+=step)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum); 
        } 
        static void Main()
        {
            Sum(1,1,100);
            Sum(1,end:100);//명명된 파라미터
            Sum(1,90);
            Sum(2);
        }
        //static int Sum(int end)
        //{
        //    int sum = 0;
        //    for (int i = 1; i <= end; i++)
        //    {
        //        sum = sum + i;
        //    }
        //    return sum;
        //}
    }
}
