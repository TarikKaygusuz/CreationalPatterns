namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Creater c = new Creater();
            Icecream strawberryIc = c.IcecreamFactory(IcecreamTypes.Strawberry);
            Icecream chocolateIc = c.IcecreamFactory(IcecreamTypes.Chocolate);

            Icecream[] icecreams = { strawberryIc, chocolateIc};
            foreach (Icecream item in icecreams)
            {
                item.Type();
            }

        }
    }
}
