using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection conn1 = ConnectionProvider.CreateConnection();
            Connection conn2 = ConnectionProvider.CreateConnection();

            Console.WriteLine(conn1.Id);
            Console.WriteLine(conn2.Id);

        }
    }
}
