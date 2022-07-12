using NUnit.Framework;

namespace Solid.DependencyInversion
{
    internal class ImportantBusinessLogicTest
    {
        [TestCase]
        public void BusinessLogicCanBeCreated()
        {
            var logic = new ImportantBusinessLogic();
        }

        [TestCase]
        public void BusinessLogicCanConnectToTheDb()
        {
            var logic = new ImportantBusinessLogic();
            var connectionString = logic.Connect();

            Assert.AreEqual("Database connection", connectionString);
        }

        [TestCase]
        public void BusinessLogicCanWriteToTheDb()
        {
            var logic = new ImportantBusinessLogic();
            logic.Connect();
            logic.Write("Hello");
        }
    }
}
