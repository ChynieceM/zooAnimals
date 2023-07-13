using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
namespace zooAnimals
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Legs { get; set; }

        public bool IsSleeping { get; set; }
        public bool IsEating { get; set; }

        //public Animal(string name, string color, int legs ) {

        //    Name = name;
        //    Color = color;
        //    Legs = legs;

        //}
        public Animal() { }
        public bool Eat()
        {
            IsEating = true;

            return IsEating;
        }

        public bool Sleep()
        {
            IsSleeping = true;

            return IsSleeping;
        }
    }
}
