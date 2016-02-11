# SqlFluent
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
