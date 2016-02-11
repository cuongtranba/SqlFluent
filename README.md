# SqlFluent [![Build status](https://ci.appveyor.com/api/projects/status/u8kpnr4mxm9qk3n8?svg=true)](https://ci.appveyor.com/project/herrylove72/sqlfluent)

help to write sql become simpler

Like :

```
        [Test]
        public void SelectClauseTest()
        {
            var actual = FluentBuilder.Create().Select("CustomerName,City").From("Customers").ToString();
            StringAssert.AreEqualIgnoringCase("SELECT CustomerName,City FROM Customers;", actual);
        }
```
