namespace esterwhen.UnitTests
{
    [TestClass]
    public class ConfrontoTests
    {
        [TestMethod]
        public void Test()
        {
            var calculator1 = new MeeusJonesButcherEasterWhenCalculator();
            var calculator2 = new ConwayEasterWhenCalculator();
            var dateEscluse = new int[] { 455, 1571, 1666, 2258, 2410 };
            for(int year = 1; year < 2500; year++)
            {
                if (dateEscluse.Contains(year))
                {
                    continue;
                }
                var d1 = calculator1.Calculate(year);
                var d2 = calculator2.Calculate(year);
                Assert.AreEqual(d1, d2);
            }            
        }
    }
}