using System;
namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kedi oluşturulmaya başlanıyor");

            AnimalBuilder animalBuilder = new CatBuilder();
            Creator catCreator = new Creator();
            catCreator.CreateAnimal(animalBuilder);

            animalBuilder.animal.Build();
            animalBuilder.animal.Move();

        }
    }
}
