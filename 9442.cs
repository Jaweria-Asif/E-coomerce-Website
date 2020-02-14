﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_TASK
{
    class Engine
    {
        protected int number_of_engine;
        public Engine(int number)
        {
            this.number_of_engine = number;
        }

    }
    class AC
    {
        protected int number_of_ac;
        public AC(int number)
        {
            this.number_of_ac = number;
        }
    }
    abstract class Vehicle
    {
        protected Engine eng0;
        protected AC ac0;
        public Vehicle(Engine e, AC Ac)
        {
            this.eng0 = e;
            this.ac0 = Ac;

        }
        public Vehicle(Engine e)
        {
            this.eng0 = e;
        }
        abstract public void display();

    }
    class LandVehicle : Vehicle
    {
        private int model;
        public LandVehicle(Engine eng2, AC ac2, int mod1) : base(eng2, ac2)
        {

            this.model = mod1;
        }
        public override void display()
        {
            Console.WriteLine("the number of engine in car :" + eng0);
            Console.WriteLine("the number of ac in car: " + ac0);
        }


    }
    class othervehicle : Vehicle
    {
        private string name;
        public othervehicle(Engine eng3, AC ac3, string name) : base(eng3, ac3)
        {

            this.name = name;
        }
        public override void display()
        {
            Console.WriteLine("the number of engine in car :" + eng0);
            Console.WriteLine("the number of ac in car: " + ac0);
        }
    }
    class drive
    {
        protected string drive_slot;
        public drive(string slot)
        {
            this.drive_slot = slot;
        }
        public void timing()
        {
            Console.WriteLine("The slot of driving is : " + drive_slot);
        }

    }
    class trip : drive
    {
        public string drive_slot;
        private int trips;
        public trip(string driving_slot, int t) : base(driving_slot)
        {
            this.trips = t;
        }
        public void timing()
        {
            Console.WriteLine("The Slot of driving is : " + drive_slot);
            Console.WriteLine("The Complete trips are  : " + trips);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Engine en = new Engine(1);
            AC ac = new AC(2);
            LandVehicle lv = new LandVehicle(en, ac, 2);
            trip tr = new trip("Morning", 3);
            drive dr = new drive("Morning");
            Console.ReadLine();





        }

    }
}
