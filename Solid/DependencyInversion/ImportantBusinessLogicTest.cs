using NUnit.Framework;

namespace Solid.DependencyInversion
{
    class ImportantBusinessLogicTest
    {
        [TestCase]
        public void BusinessLogicCanBeCreated()
        {
            var logic = new ImportantBusinessLogic();
        }

        [TestCase]
        public void BusinessLogicCanConnectToTheDB()
        {
            var logic = new ImportantBusinessLogic();
            var connectionString = logic.Connect();

            Assert.AreEqual("Database connection", connectionString);
        }

        [TestCase]
        public void BusinessLogicCanWriteToTheDB()
        {
            var logic = new ImportantBusinessLogic();
            logic.Connect();
            logic.Write("Hello");
        }
    }
}
