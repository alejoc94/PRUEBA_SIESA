using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA_SIESA
{
    internal class PUNTO_5
    {
        public int punto5(int num)
        {
            if (num < 3)
            {
                return num;
            }
            return punto5(num - 1) * punto5(num - 2);
        }
    }
}
