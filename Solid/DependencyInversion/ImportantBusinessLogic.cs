using System;

namespace Solid.DependencyInversion
{
    class ImportantBusinessLogic
    {
        DatabaseAccess.MySQLConnection connection = new DatabaseAccess.MySQLConnection();

        internal object Connect()
        {    
            return connection.connect();
        }

        internal void Write(string v)
        {
            connection.open();
            connection.execute("ADD v");
            connection.close();
        }
    }
}
