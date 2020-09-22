using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    interface IMan
    {
        string Name { get; set; }
        void save();
        void show();
    }
    interface IPerson:IMan
    {
        int Age { get; set; }
    }

    class Employee : IPerson
    {
        int age;
        public int Age { get { return age; } set { age = value; } }
        string name;
        public string Name { get { return name; } set { name = value; } }
        

        public void save()
        {
            Console.WriteLine("Name:"+this.name);
        }

        public void show()
        {
            Console.WriteLine("Name:" + this.name);
            Console.WriteLine("Show:" + this.age);
        }
    }
    class Interface_1
    {
        static void Main()
        {
            Employee man = new Employee();
            
        }
    }
}
