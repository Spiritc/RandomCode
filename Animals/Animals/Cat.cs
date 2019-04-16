namespace Animals.Animals
{
    public class Cat : Animal
    {
        private string sound = "Meow meow";


        public Cat(string name, int age, string gender) : base(name, age, gender)
        {

        }


        public override void ProduceSound()
        {
            System.Console.WriteLine(sound);
        }

    }
}