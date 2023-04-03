using System.Data;
using System.Globalization;

namespace esterwhen.UnitTests
{
    [TestClass]
    public class ConwayEasterWhenCalculatorTests
    {
        [TestMethod]
        [DataRow(1950, "09/04/1950")]
        [DataRow(1951, "25/03/1951")]
        [DataRow(1952, "13/04/1952")]
        [DataRow(1953, "05/04/1953")]
        [DataRow(1954, "18/04/1954")]
        [DataRow(1955, "10/04/1955")]
        [DataRow(1956, "01/04/1956")]
        [DataRow(1957, "21/04/1957")]
        [DataRow(1958, "06/04/1958")]
        [DataRow(1959, "29/03/1959")]
        [DataRow(1960, "17/04/1960")]
        [DataRow(1961, "02/04/1961")]
        [DataRow(1962, "22/04/1962")]
        [DataRow(1963, "14/04/1963")]
        [DataRow(1964, "29/03/1964")]
        [DataRow(1965, "18/04/1965")]
        [DataRow(1966, "10/04/1966")]
        [DataRow(1967, "26/03/1967")]
        [DataRow(1968, "14/04/1968")]
        [DataRow(1969, "06/04/1969")]
        [DataRow(1970, "29/03/1970")]
        [DataRow(1971, "11/04/1971")]
        [DataRow(1972, "02/04/1972")]
        [DataRow(1973, "22/04/1973")]
        [DataRow(1974, "14/04/1974")]
        [DataRow(1975, "30/03/1975")]
        [DataRow(1976, "18/04/1976")]
        [DataRow(1977, "10/04/1977")]
        [DataRow(1978, "26/03/1978")]
        [DataRow(1979, "15/04/1979")]
        [DataRow(1980, "06/04/1980")]
        [DataRow(1981, "19/04/1981")]
        [DataRow(1982, "11/04/1982")]
        [DataRow(1983, "03/04/1983")]
        [DataRow(1984, "22/04/1984")]
        [DataRow(1985, "07/04/1985")]
        [DataRow(1986, "30/03/1986")]
        [DataRow(1987, "19/04/1987")]
        [DataRow(1988, "03/04/1988")]
        [DataRow(1989, "26/03/1989")]
        [DataRow(1990, "15/04/1990")]
        [DataRow(1991, "31/03/1991")]
        [DataRow(1992, "19/04/1992")]
        [DataRow(1993, "11/04/1993")]
        [DataRow(1994, "03/04/1994")]
        [DataRow(1995, "16/04/1995")]
        [DataRow(1996, "07/04/1996")]
        [DataRow(1997, "30/03/1997")]
        [DataRow(1998, "12/04/1998")]
        [DataRow(1999, "04/04/1999")]
        [DataRow(2000, "23/04/2000")]
        [DataRow(2001, "15/04/2001")]
        [DataRow(2002, "31/03/2002")]
        [DataRow(2003, "20/04/2003")]
        [DataRow(2004, "11/04/2004")]
        [DataRow(2005, "27/03/2005")]
        [DataRow(2006, "16/04/2006")]
        [DataRow(2007, "08/04/2007")]
        [DataRow(2008, "23/03/2008")]
        [DataRow(2009, "12/04/2009")]
        [DataRow(2010, "04/04/2010")]
        [DataRow(2011, "24/04/2011")]
        [DataRow(2012, "08/04/2012")]
        [DataRow(2013, "31/03/2013")]
        [DataRow(2014, "20/04/2014")]
        [DataRow(2015, "05/04/2015")]
        [DataRow(2016, "27/03/2016")]
        [DataRow(2017, "16/04/2017")]
        [DataRow(2018, "01/04/2018")]
        [DataRow(2019, "21/04/2019")]
        [DataRow(2020, "12/04/2020")]
        [DataRow(2021, "04/04/2021")]
        [DataRow(2022, "17/04/2022")]
        [DataRow(2023, "09/04/2023")]
        [DataRow(2024, "31/03/2024")]
        [DataRow(2025, "20/04/2025")]
        [DataRow(2026, "05/04/2026")]
        [DataRow(2027, "28/03/2027")]
        [DataRow(2028, "16/04/2028")]
        [DataRow(2029, "01/04/2029")]
        [DataRow(2030, "21/04/2030")]
        [DataRow(2031, "13/04/2031")]
        [DataRow(2032, "28/03/2032")]
        [DataRow(2033, "17/04/2033")]
        [DataRow(2034, "09/04/2034")]
        [DataRow(2035, "25/03/2035")]
        [DataRow(2036, "13/04/2036")]
        [DataRow(2037, "05/04/2037")]
        [DataRow(2038, "25/04/2038")]
        [DataRow(2039, "10/04/2039")]
        [DataRow(2040, "01/04/2040")]
        [DataRow(2041, "21/04/2041")]
        [DataRow(2042, "06/04/2042")]
        [DataRow(2043, "29/03/2043")]
        [DataRow(2044, "17/04/2044")]
        [DataRow(2045, "09/04/2045")]
        [DataRow(2046, "25/03/2046")]
        [DataRow(2047, "14/04/2047")]
        [DataRow(2048, "05/04/2048")]
        [DataRow(2049, "18/04/2049")]
        [DataRow(2050, "10/04/2050")]
        public void Test(int year, string expectedDateStr)
        {
            var expectedDate = DateTime.ParseExact(expectedDateStr, "dd/MM/yyyy", new CultureInfo("it-IT"));
            var calculator = new ConwayEasterWhenCalculator();
            var easter = calculator.Calculate(year);
            Assert.AreEqual(expectedDate, easter);
        }
    }
}