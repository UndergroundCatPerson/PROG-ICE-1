using IceTask1_PROG;

namespace PetTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestID()
        {
            Pet p = new Pet(500, "MJ001", "Cat", "Casper", "Russian Blue");
            Assert.AreEqual(p[1], "MJ001");
        }


        [TestMethod]
        public void TestUpdatedPetBill()
        {
            Pet p = new Pet(500.00, "MJ001", "Cat", "Casper", "Russian Blue");
            p[0] = 600.00;
            Assert.AreEqual(p[0], 600.00);
        }

        [TestMethod]
        public void TestUpdatedPetBreed()
        {
            Pet p = new Pet(500, "MJ001", "Cat", "Casper", "Russian Blue");
            p[4] = "Snow leopard";
            Assert.AreEqual(p[4], "Snow leopard");
        }

        [TestMethod]
        public void TestPetBreedUpdate_InvalidValue()
        {
            Pet p = new Pet(500, "MJ001", "Cat", "Casper", "Russian Blue");
            p[4] = ""; 
            Assert.AreEqual(p[4], "Russian Blue"); 
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestID_InvalidIndex()
        {
            Pet p = new Pet(500, "MJ001", "Cat", "Casper", "Russian Blue");
            Assert.AreEqual(p[10], "Russian Blue");
        }

 





    }
}