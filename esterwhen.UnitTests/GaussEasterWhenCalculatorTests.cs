using System.Data;
using System.Globalization;

namespace esterwhen.UnitTests
{
    [TestClass]
    public class GaussEasterWhenCalculatorTests
    {
        [TestMethod]
        [DynamicData(nameof(TestDataSource.Data), typeof(TestDataSource))]
        public void Test(int year, string expectedDateStr)
        {
            var expectedDate = DateTime.ParseExact(expectedDateStr, "dd/MM/yyyy", new CultureInfo("it-IT"));
            var calculator = new GaussEasterWhenCalculator();
            var easter = calculator.Calculate(year);
            Assert.AreEqual(expectedDate, easter);
        }
    }
}