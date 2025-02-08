using ClassLibrary;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Square_16_16returns()
        {
            double perimeter = 16;
            double expected = 16;

            var result = Farmer.Square(perimeter);

            Assert.AreEqual(expected, result);
        }
    }
}