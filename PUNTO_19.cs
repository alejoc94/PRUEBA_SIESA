using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PRUEBA_SIESA.PUNTO_19;

namespace PRUEBA_SIESA
{
    internal class PUNTO_19
    {
        public class RamaArbol<subarbol, p>
        {
            public subarbol nombre { get; set; }
            public p peso { get; set; }
            public List<RamaArbol<subarbol, p>> Hijo { get; set; }

            public RamaArbol(subarbol n, p p)
            {
                this.nombre = n;
                this.peso = p;
                this.Hijo = new List<RamaArbol<subarbol, p>>();
            }
            
            public void agregarHijo(RamaArbol<subarbol, p> hijo)
            {
                this.Hijo.Add(hijo);
            }
        }

        public class Arbol<arbol, peso>
        {
            public RamaArbol<arbol, peso> Tronco { get; set; }

            public Arbol(arbol a, peso p)
            {
                Tronco = new RamaArbol<arbol, peso>(a, p);
            }
        }

        public PUNTO_19() 
        {
            //ARBOL 1
            Arbol<string, int> arbol_p1= new Arbol<string, int>("ARBOL 1", 4);

            //ARBOL 2
            Arbol<string, int> arbol_p2 = new Arbol<string, int>("ARBOL 1", 4);
            RamaArbol<string, int> arbol8 = new("ARBOL 2", 1);
            RamaArbol<string, int> arbol9 = new("ARBOL 3", 2);

            arbol_p2.Tronco.agregarHijo(arbol8);
            arbol_p2.Tronco.agregarHijo(arbol9);

            //ARBOL 3
            Arbol<string, int> arbol_p3 = new Arbol<string, int>("ARBOL 1",4);

            RamaArbol<string, int> arbol2 = new("ARBOL 2",1);
            RamaArbol<string, int> arbol3 = new("ARBOL 3",2);
            RamaArbol<string, int> arbol4 = new("ARBOL 4", 5);

            RamaArbol<string, int> arbol5 = new("ARBOL 5", 3);
            RamaArbol<string, int> arbol6 = new("ARBOL 6", 1);
            RamaArbol<string, int> arbol7 = new("ARBOL 7", 4);

            arbol_p3.Tronco.agregarHijo(arbol2);
            arbol_p3.Tronco.agregarHijo(arbol3);
            arbol_p3.Tronco.agregarHijo(arbol4);

            arbol3.agregarHijo(arbol5);
            arbol4.agregarHijo(arbol6);
            arbol4.agregarHijo(arbol7);

            Console.WriteLine("ARBOL 1");
            mostrar_datos(calcular_datos(arbol_p1.Tronco, null));

            Console.WriteLine("\r\nARBOL 2");
            mostrar_datos(calcular_datos(arbol_p2.Tronco, null));

            Console.WriteLine("\r\nARBOL 3");
            mostrar_datos(calcular_datos(arbol_p3.Tronco, null));


        }

        public decimal[] calcular_datos(RamaArbol<string, int> arbol, int? nivel)
        {
            //SE RECIBE NULL CUANDO SE VA A CALCULAR DESDE EL INICIO DEL ARBOL
            decimal[] datos = new decimal[3];
            decimal[] datos2 = new decimal[3];
            int cont = 1;
            string nombre = arbol.nombre;
            int peso = arbol.peso;

            datos[0] = 0;
            if (nivel == null) { nivel = 1;}


            if (arbol.Hijo.Count > 0)
            {                
                datos[0] += peso; //PESO
                datos[1] = Convert.ToInt32(nivel); //ALTURA
                datos[2] += cont; //CONTADOR
                nivel++;
                foreach (var item in arbol.Hijo)
                {
                    datos2 = calcular_datos(item, nivel);
                    datos[0] += datos2[0]; //PESO
                    datos[1] =  datos2[1]; //ALTURA
                    datos[2] += datos2[2]; //CONTADOR
                }
            }
            else
            {
                datos[0] += peso; //PESO
                datos[1] = Convert.ToInt32(nivel); //ALTURA
                datos[2] += cont; //CONTADOR
            }
            return datos;
        }

        public void mostrar_datos(decimal[] datos)
        {
            decimal promedio = datos[0] / datos[2];
            Console.WriteLine("PESO ARBOL: " + Convert.ToString(datos[0]));
            Console.WriteLine("PESO PROMEDIO ARBOL: " + Convert.ToString(promedio));
            Console.WriteLine("ALTURA ARBOL: " + Convert.ToString(datos[1]));
        }
      
    }
}
