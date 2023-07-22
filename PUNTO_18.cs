using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA_SIESA
{
    internal class PUNTO_18
    {
        public PUNTO_18() 
        {
            string acum_base = "";
            int cociente = 0;
            int residuo = 0;
            int num_ini = 0;

            Console.WriteLine("Ingrese en base 10 el numero al que desea cambiar de base");
            int num = Convert.ToInt32(Console.ReadLine());
            num_ini = num;

            Console.WriteLine("Ingrese la base a la que desea convertir el numero");
            int bas = Convert.ToInt32(Console.ReadLine());

            if (bas == 0)
            {
                Console.WriteLine("La base no puede ser cero(0).");
                return;
            }

            if (num < bas)
            {
                acum_base = Convert.ToString(num % bas);
            }
            else
            {
                while (num >= bas)
                {
                    cociente = num / bas;
                    residuo = num % bas;

                    acum_base = Convert.ToString(residuo) + acum_base;
                    num = cociente;
                }
                acum_base = Convert.ToString(cociente) + acum_base;
            }
            
            Console.WriteLine("El numero " + Convert.ToString(num_ini) + " convertido a base " + Convert.ToString(bas) + " es: " + acum_base);
        }
    }
}
