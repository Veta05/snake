﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class LengthException : Exception
    {
        public override string Message
        {
            get
            {
                return "Enter please minimum 3 charters";
            }
        }
    }
}
