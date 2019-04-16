﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Animals
{
    public abstract class Animal : ISoundProducable
    {

        
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (value == null || String.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid input!");
                }
                name = value;
            }
        }
        public int Age
        {
            get => age;
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid input!");
                }
                age = value;
            }
        }
        public string Gender
        {
            get => gender;
            private set
            {
                if (value == null || String.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid input!");
                }
                gender = value;
            }
        }


        public virtual void ProduceSound()
        {
            Console.WriteLine("BAUUUUU");
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Gender}";
        }
    }
}
