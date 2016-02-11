﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlFluent
{
    public interface IWhere
    {
        IOperator Where(string value);
        IWhere OrderBy(string value);
    }
}
