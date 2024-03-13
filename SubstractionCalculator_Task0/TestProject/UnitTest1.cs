namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SubstractionCalculator calculator = new SubstractionCalculator();
            int firstnumber = 20;
            int secondnumber = 2;
            int expectedResult = 18;
            
            int realResult = calculator.Subtract(firstnumber, secondnumber);

            Assert.AreEqual(expectedResult, realResult);
        }
    }
}