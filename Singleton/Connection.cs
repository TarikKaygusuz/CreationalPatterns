using System;

namespace Singleton
{
    class Connection
    {
        private Guid id;

        public Guid Id
        {
            get { return id; }
        }

        public Connection()
        {
            // Tek instance alındığını göstermek için atanmış Unique Identifier değer.
            id =  Guid.NewGuid();
        }
    }
}
