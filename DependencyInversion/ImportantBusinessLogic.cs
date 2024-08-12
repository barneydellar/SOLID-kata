namespace DependencyInversion;

internal class ImportantBusinessLogic
{
    private readonly DatabaseAccess.MySqlConnection _connection = new();

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