using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlFluent
{
    public interface IFrom
    {
        IWhere From(string value);
    }
}
