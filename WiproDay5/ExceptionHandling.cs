﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproDay5
{
    internal class AgeExce : Exception
    {
        public AgeExce(string errmsg) : base(errmsg){ }
    }
}
