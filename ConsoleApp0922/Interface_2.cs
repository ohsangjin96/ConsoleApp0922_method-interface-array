using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void fly();
    }
    class FlyingBike : IFlyable, IRunnable
    {
        public void fly()
        {
            Console.WriteLine("Bike Fly");
        }
        public void Run()
        {
            Console.WriteLine("Bike Run");
        }
    }

    class FlyingCar : IFlyable, IRunnable
    {
        public void fly()
        {
            Console.WriteLine("Car Fly");
        }
        public void Run()
        {
            Console.WriteLine("Car Run");
        }
    }
    class Interface_2
    {
        static void Main()
        {
            FlyingCar car = new FlyingCar();
            car.fly();
            car.Run();
            Flying(car);
            FlyingBike bike = new FlyingBike();
            bike.fly();
            bike.Run();
            Flying(bike);
        }

        public static void Flying(IFlyable flyer)//인터페이스의 다형성
        {
            flyer.fly();
        }
        public static void Runable(IRunnable runner)//인터페이스의 다형성(피라미터에 부모를 넣는다(interface))
        {
            runner.Run();
        }



        //static void Flying(FlyingCar car)
        //{
        //    car.fly();
        //}
        //static void Flying(FlyingBike bike)
        //{
        //    bike.fly();
        //}
    }
}
