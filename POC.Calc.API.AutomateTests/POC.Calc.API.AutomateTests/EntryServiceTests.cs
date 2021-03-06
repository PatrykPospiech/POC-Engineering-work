using System.Collections;
using System.Diagnostics;
using NUnit.Framework;
using POC.Calc.API.Controllers;

namespace POC.Calc.API.AutomateTests
{
    [TestFixture]
    public class EntryServiceTests
    {
        private EntryController _entryController;

        [SetUp]
        public void SetUp()
        {
            _entryController = new EntryController();
        }

        [Test]
        public void AddEntry()
        {
            var databaseModel = new DatabaseModel
            {
                ID = 1,
                Dane = "test"
            };
            _entryController.AddDatabaseModel(databaseModel);

            var result = _entryController.GetDatabaseModel();

            Assert.Contains(databaseModel, result as ICollection);
        }
    }
}