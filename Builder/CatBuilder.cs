namespace Builder
{
   public class CatBuilder:AnimalBuilder
    {
        public CatBuilder()
        {
            animal = new Cat();
        }
        public override void BuildHead() {
            animal.Head = "Kedinin kafası oluşturuldu";
        }
        public override void BuildBody() {
            animal.Body = "Kedinin vucudu oluşturuldu";
        }
        public override void BuildLeg() {
            animal.Leg = "Kedinin bacakları oluşturuldu";
        }
        public override void BuildArm() {
            animal.Arm = "Kedinin kolları oluşturuldu";
        }
    }
}
