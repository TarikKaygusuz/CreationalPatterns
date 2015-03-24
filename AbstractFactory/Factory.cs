using System;

namespace AbstractFactory
{

    public abstract class Phone
    {
        public abstract void Call();

    }

    public class IOS : Phone
    {
        public override void Call()
        {
            Console.WriteLine("IOS sistemli telefondan arama yapıldı.");
        }
    }

    public class Android : Phone
    {
        public override void Call()
        {
            Console.WriteLine("Android sistemli telefondan arama yapıldı.");
        }
    }


    public abstract class PhoneFactory
    {
        public abstract Phone Create();
    }

    public class GoogleFactory : PhoneFactory
    {
        public override Phone Create()
        {
            return new Android();
        }
    }

    public class AppleFactory : PhoneFactory
    {
        public override Phone Create()
        {
            return new IOS();
        }
    }


     public class Factory
     {
         private PhoneFactory _phoneFactory;
         private Phone _phone;

         public Factory(PhoneFactory phoneFactory)
         {
             _phoneFactory = phoneFactory;
             _phone = phoneFactory.Create();
         }

         public void Use()
         {
             _phone.Call();
         }
     }

}
