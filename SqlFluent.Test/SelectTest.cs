using NUnit.Framework;

namespace SqlFluent.Test
{
    [TestFixture]
    public class SelectTest
    {
        [Test]
        public void SelectClauseTest()
        {
            var actual = FluentBuilder.Create().Select("CustomerName,City").From("Customers").ToString();
            StringAssert.AreEqualIgnoringCase("SELECT CustomerName,City FROM Customers;", actual);
        }

        [Test]
        public void SelectDistinctClauseTest()
        {
            var actual = FluentBuilder.Create().SelectDistinct("City").From("Customers").ToString();
            StringAssert.AreEqualIgnoringCase("SELECT DISTINCT City FROM Customers;", actual);
        }


    }
}
