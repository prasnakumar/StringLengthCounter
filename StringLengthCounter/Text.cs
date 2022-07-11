using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLengthCounter
{
    public  class LengthHelper
    {
        public int findLength(string? value)
        {
            if (String.IsNullOrEmpty(value)) return 0;
           
            return(value.Length);

        }
    }
}
