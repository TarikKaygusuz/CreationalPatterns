namespace Builder
{
    public class Creator
    {
        public void CreateAnimal(AnimalBuilder animalBuilder)
        {
            animalBuilder.BuildHead();
            animalBuilder.BuildBody();
            animalBuilder.BuildLeg();
            animalBuilder.BuildArm();
        }
    }
}
