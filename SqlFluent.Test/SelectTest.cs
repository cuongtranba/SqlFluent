using System;
using NUnit.Framework;
using SqlFluent;

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
    }
}
