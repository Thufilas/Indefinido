using System;
using System.Collections.Generic;
using System.Text;

namespace RMJ.Comum
{
    class MatematicaUtil
    {
        public static decimal Divisao(decimal a, decimal b)
        {
            if (b == 0)
                return 0;

            return a / b;
        }
    }
}
