using System;

namespace Solid.DependencyInversion
{
    class ImportantBusinessLogic
    {
        readonly DatabaseAccess.MySQLConnection connection = new DatabaseAccess.MySQLConnection();

        public object Connect()
        {    
            return connection.connect();
        }

        public void Write(string v)
        {
            connection.open();
            connection.execute("ADD " + v);
            connection.close();
        }
    }
}
