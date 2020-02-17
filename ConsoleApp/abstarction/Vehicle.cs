using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.abstarction
{
    public class X
    {
        public void ShowX()
        {
           Console.WriteLine ("this is X ");
        }
    }

    public class A:X
    {
        public void ShowA()
        {
            Console.WriteLine("this is A ");
        }
    }
    public abstract class Vehicle:A
    {
        public   int Id { get; set; }
       
        public abstract void Display();

        public  void Show(string Param)
        {
            Console.WriteLine(Param);
        }

        public virtual  string Hot()
        {
            return "Not much is known about this four legged animal!";
        }
    }

    public class Bus : Vehicle
    {
        
        public override void Display()
        {
            Console.WriteLine("Bus");
        }
        public override string Hot()
        {
            return "This four legged animal is a Dog!";
        }
    }

    public class Car : Vehicle
    {
        public override void Display()
        {
            Console.WriteLine("Car");
        }
    }
    public class MotorCycle : Vehicle
    {
        public override void Display()
        {
            Console.WriteLine("MotorCcyle");
        }
    }
}
