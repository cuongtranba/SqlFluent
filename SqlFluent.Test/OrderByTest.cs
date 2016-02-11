using NUnit.Framework;

namespace SqlFluent.Test
{
    [TestFixture]
    class OrderByTest
    {
        [Test]
        public void OrderByClauseTest()
        {
            var actual = FluentBuilder.Create().Select("*").From("Customers").OrderBy("Country ASC, CustomerName DESC").ToString();
            StringAssert.AreEqualIgnoringCase("SELECT * FROM Customers ORDER BY Country ASC, CustomerName DESC;",actual);
        }
    }
}
