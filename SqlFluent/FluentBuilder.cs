using System;
using System.Text;

namespace SqlFluent
{
    public class FluentBuilder : IBaseStatement
    {
        private StringBuilder sqlQuery = new StringBuilder();
        private FluentBuilder() { }
        IWhere IFrom.From(string value)
        {
            return Add(" FROM " + value);
        }

        IOperator IWhere.Where(string value)
        {
            return Add(" WHERE " + value);
        }

        public IWhere OrderBy(string value)
        {
            return Add(" ORDER BY " + value);
        }


        public IFrom Select(string values)
        {
            return Add("SELECT " + values);
        }

        public IFrom SelectDistinct(string values)
        {
            return Add("SELECT DISTINCT " + values);
        }

        private FluentBuilder Add(string value)
        {
            sqlQuery.Append(value);
            return this;
        }


        public override string ToString()
        {
            sqlQuery.Append(";");
            return sqlQuery.ToString();
        }

        public static FluentBuilder Create()
        {
            return new FluentBuilder();
        }

        string IOperator.And(string value)
        {
            throw new NotImplementedException();
        }

        string IOperator.Or(string value)
        {
            throw new NotImplementedException();
        }

        string IOperator.Like(string value)
        {
            throw new NotImplementedException();
        }

        string IOperator.NotLike(string value)
        {
            throw new NotImplementedException();
        }

        string IOperator.Between(string value1, string value2)
        {
            throw new NotImplementedException();
        }
    }
}
