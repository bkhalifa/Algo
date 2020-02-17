using System;
using System.Linq;
using System.Collections;
using ConsoleApp.abstarction;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle v ;
            v = new Bus();
            v.Display();
            v.Show("Bus");
            v.Hot();
            v.ShowA();
            v.ShowX();

            v = new Car();
            v.Display();
            v.Show("Car");
            

            v = new MotorCycle();
            v.Display();
            v.Show("MotorCycle");

            bool b = false;

            bool c = b ? !b : b;


            Console.WriteLine(c);

            ArrayList arrLi = new ArrayList();

            arrLi.Add(1);
            arrLi.Add(new Package { Id = 1, Cost = 12.23m });
            arrLi.Add("bilel");

    

            foreach(var item in arrLi)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
