namespace Singleton
{
    class ConnectionProvider
    {
        //Static değişken.
        private static Connection conn = null;

        //Lock objesi.
        private static object _lockObject = new object();

        //Instance alınamaması için private constructor.
        private ConnectionProvider() { }


        //Static method.
        public static Connection CreateConnection()
        {
            // Connection null ise instance alınabilsin.
            if (conn == null)
            {
                // Instance alabilmek için, kaynağı kullanan diğer threed'i bekler.
                lock (_lockObject)
                {
                    if (conn == null)
                        conn = new Connection();
                }
            }
            return conn; // Connection döndür.

        }

    }

}
