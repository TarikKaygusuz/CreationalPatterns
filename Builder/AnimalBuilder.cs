using System;

namespace Builder
{
    public abstract class AnimalBuilder
    {
        public Animal animal;

        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildLeg();
        public abstract void BuildArm();
    }

    public abstract class Animal
    {
        public string Head { get; set; }
        public string Body { get; set; }
        public string Leg { get; set; }
        public string Arm { get; set; }

        public abstract void Move();

        public void Build()
        {
            Console.WriteLine(Head);
            Console.WriteLine(Body);
            Console.WriteLine(Leg);
            Console.WriteLine(Arm);
        }
    }

    public class Cat : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Miyuvvvvvvv....");
        }
    }

}
