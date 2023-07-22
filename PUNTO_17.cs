using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA_SIESA
{
    internal class PUNTO_17
    {
        public PUNTO_17()
        {
            punto17();
        }

        public void punto17()
        {
            Console.WriteLine("Ingrese el dividendo");
            decimal a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el divisor");
            decimal b = Convert.ToInt32(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("No se puede dividir por cero.");
                return;
            }

            decimal res = a / b;
            Console.WriteLine("El resultado de la división es: " + Convert.ToString(res));
        }


    }
}
