using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    interface IRunnable2
    {
        void Run();
    }
    interface IFlyable2
    {
        void fly();
    }

    abstract class Fly//추상클래스
    {
        public abstract void CFly();//추상메서드는 앞에 abstract를 붙여야 한다.
        public abstract void CRun();
    }
    class FlyingBike2 : Fly,IFlyable2, IRunnable2//주 된것은 클래스로 상속받고 나머지는 인터페이스로 상속받는다.
    {
        public override void CFly()//인터페이스를 상속받을때는 override를 안쓰고 클래스를 상속받을때는 override를 사용
        {
            Console.WriteLine("Bike Fly");
        }
        public override void CRun()
        {
            Console.WriteLine("Bike Run");
        }

        public void fly()
        {
            Console.WriteLine("Bike Fly");
        }
        public void Run()
        {
            Console.WriteLine("Bike Run");
        }
    }

    class FlyingCar2 : Fly,IFlyable, IRunnable
    {
        public override void CFly()
        {
            Console.WriteLine("Car Fly");
        }
        public override void CRun()
        {
            Console.WriteLine("Car Run");
        }
        public void fly()
        {
            Console.WriteLine("Car Fly");
        }
        public void Run()
        {
            Console.WriteLine("Car Run");
        }
       
    }
    class Interface_3
    {
        static void Main()
        {
            FlyingCar2 car = new FlyingCar2();
            car.CFly();
            car.CRun();
            Flying(car);

            FlyingBike2 bike = new FlyingBike2();
            bike.fly();
            bike.Run();
            Flying(bike);

            Fly[] arr = new Fly[3];
            arr[0] = new FlyingCar2();
            arr[1] = new FlyingBike2();
            arr[2] = new FlyingBike2();

            foreach(Fly temp in arr)
            {
                temp.CFly();
            }
        }
    static void Flying(Fly flyer)
        {
            flyer.CFly();
        }
    
    }

}
