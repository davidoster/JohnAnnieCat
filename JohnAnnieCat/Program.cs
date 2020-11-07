using System;
using System.Collections.Generic;
using JohnAnnieCat.Models;

namespace JohnAnnieCat
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Mammal m = new Mammal();
            //Human john = new Human();
            //Cat ann = new Cat();
            //Mouse jerry = new Mouse();

            Mammal john = new Human();
            john.Name = "John";
            //Console.WriteLine(john.Name);

            Mammal ann = new Cat();
            ann.Name = "Ann";

            Mammal jerry = new Mouse();
            jerry.Name = "Jerry";

            //House h = new House();
            //Console.WriteLine(h);

            //Interior i = new Interior(john, ann);
            //Garden g = new Garden(new List<Mammal>() { jerry });

            //House house = new House(i, g);

            House house1 = new House(new Interior(john, ann), new Garden(new List<Mammal>() { jerry }));

            house1.Interior.mammals[0].Move(new Location(), new Location(), Speed.ZERO);
            

            Console.ReadLine();

        }
    }
}
