using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlFluent
{
    public class FluentBuilder:IBaseStatement
    {
        private StringBuilder sqlQuery=new StringBuilder();
        IWhere IFrom.From(string value)
        {
            return Add(" FROM " + value);
        }

        IOperator IWhere.Where(string value)
        {
            throw new NotImplementedException();
        }

        public string OrderBy(string value)
        {
            throw new NotImplementedException();
        }

        public IFrom Select(string values)
        {
            return Add("SELECT " + values);
        }

        public IFrom SelectDistinct(string values)
        {
            throw new NotImplementedException();
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
    }
}
