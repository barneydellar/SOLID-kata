using System;

namespace Solid.DependencyInversion
{
    internal class ImportantBusinessLogic
    {
        private readonly DatabaseAccess.MySqlConnection _connection = new DatabaseAccess.MySqlConnection();

        public object Connect()
        {    
            return _connection.Connect();
        }

        public void Write(string v)
        {
            _connection.Open();
            _connection.Execute("ADD " + v);
            _connection.Close();
        }
    }
}
