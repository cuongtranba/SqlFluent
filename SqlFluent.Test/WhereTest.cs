using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SqlFluent.Test
{
    [TestFixture]
    class WhereTest
    {
        [Test]
        public void WhereClauseTest()
        {
            var actual = FluentBuilder.Create().Select("*").From("Customers").Where("Country = 'Mexico'").ToString();
            StringAssert.AreEqualIgnoringCase("SELECT * FROM Customers WHERE Country = 'Mexico';",actual);
        }
    }
}
