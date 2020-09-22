using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    class Method_ex
    {
        static void Decimal(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (i%2!= 0)
                {
                    if (i % 3 != 0)
                    {
                        if (i % 5 != 0)
                        {
                            if (i % 7 != 0)
                            {
                                Console.Write(i + " ");
                            }
                        }
                    }
                }
            }
        }

        
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            Decimal(num);
        }
    }
}
