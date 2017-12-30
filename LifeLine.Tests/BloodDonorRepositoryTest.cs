using LifeLine.Core;
using LifeLine.Infrastructure;
using LifeLine.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
namespace LifeLine.Tests
{
    [TestClass]
    class BloodDonorRepositoryTest
    {
        BloodDonorRepository repo;
        [TestInitialize]
        public void TestSetUp()
        {

            BloodDonorInitalizeDb db = new BloodDonorInitalizeDb();
            System.Data.Entity.Database.SetInitializer(db);
            repo = new BloodDonorRepository();
        }

        [TestMethod]
        public void IsRepositoryInitalizeWithValidNumberOfData()
        {
            var result = repo.GetBloodDonors();
            Assert.IsNotNull(result);
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(2, numberOfRecords);
        }
    }
}
