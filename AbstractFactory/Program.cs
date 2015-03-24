namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory iphone = new Factory(new AppleFactory());
            iphone.Use();

            Factory samsung = new Factory(new GoogleFactory());
            samsung.Use();

        }
    }
}
