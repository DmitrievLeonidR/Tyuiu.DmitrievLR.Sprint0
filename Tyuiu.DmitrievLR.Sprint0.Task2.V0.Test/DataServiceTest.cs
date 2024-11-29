using Tyuiu.DmitrievLR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DmitrievLR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = "Test";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Test", res);
        }
    }
}