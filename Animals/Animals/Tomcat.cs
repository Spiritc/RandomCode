using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Animals
{
    public class Tomcat : Cat
    {
        private string sound = "MEOW";
        private const string gender = "Male";

        public Tomcat(string name, int age) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(sound);
        }
    }
}
