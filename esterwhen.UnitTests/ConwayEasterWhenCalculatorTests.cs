using System.Data;
using System.Globalization;

namespace esterwhen.UnitTests
{
    [TestClass]
    public class ConwayEasterWhenCalculatorTests
    {
        [TestMethod]
        [DynamicData(nameof(TestDataSource.Data), typeof(TestDataSource))]
        public void Test(int year, string expectedDateStr)
        {
            var expectedDate = DateTime.ParseExact(expectedDateStr, "dd/MM/yyyy", new CultureInfo("it-IT"));
            var calculator = new ConwayEasterWhenCalculator();
            var easter = calculator.Calculate(year);
            Assert.AreEqual(expectedDate, easter);
        }
    }
}