using System;
namespace FactoryMethod
{
    public enum IcecreamTypes
    {
        Strawberry,
        Chocolate,
        Vanilla
    }

    public abstract class Icecream
    {
        public abstract void Type();
    }

    public class StrawberryIcecream : Icecream
    {
        public override void Type(){
            Console.WriteLine("Strawberry Icecream");
        }
    }

    public class ChocolateIcecream : Icecream
    {
        public override void Type(){
            Console.WriteLine("Chocolate Icecream");
        }
    }

    public class VanillaIcecream : Icecream
    {
        public override void Type(){
            Console.WriteLine("Vanilla Icecream");
        }
    }

    class Creater
    {
        public Icecream IcecreamFactory(IcecreamTypes type)
        {
            Icecream icecream = null;
            switch (type)
            {
                case IcecreamTypes.Strawberry:
                    icecream = new StrawberryIcecream();
                    break;
                case IcecreamTypes.Chocolate:
                    icecream = new ChocolateIcecream();
                    break;
                case IcecreamTypes.Vanilla:
                    icecream = new VanillaIcecream();
                    break;
            }
            return icecream;
        }

    }

}
