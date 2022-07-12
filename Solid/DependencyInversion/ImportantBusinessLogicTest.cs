using NUnit.Framework;

namespace Solid.DependencyInversion;

internal class ImportantBusinessLogicTest
{
    [Test]
    public void BusinessLogicCanBeCreated()
    {
        var logic = new ImportantBusinessLogic();
    }

    [Test]
    public void BusinessLogicCanConnectToTheDb()
    {
        var logic = new ImportantBusinessLogic();
        var connectionString = logic.Connect();

        Assert.AreEqual("Database connection", connectionString);
    }

    [Test]
    public void BusinessLogicCanWriteToTheDb()
    {
        var logic = new ImportantBusinessLogic();
        logic.Connect();
        logic.Write("Hello");
    }
}