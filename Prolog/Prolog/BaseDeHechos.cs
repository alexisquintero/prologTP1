using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolog
{
    class BaseDeHechos  //La "base de hechos" está hardcodeada para hacerla más similar a prolog
    {
        public static List<nodo> nodos = new List<nodo>();

        public static void incializarNodos()
        {
            crearCiudades();
            agregarConexiones();
        }
        private static void crearCiudades()
        {
            nodos.Add(new nodo("ciudad1"));
            nodos.Add(new nodo("ciudad2"));
            nodos.Add(new nodo("ciudad3"));
            nodos.Add(new nodo("ciudad4"));
            nodos.Add(new nodo("ciudad5"));
            nodos.Add(new nodo("ciudad6"));
        }
        private static void agregarConexiones()
        {
            //Ciudad 1 -> ciudad 2 y 4
            nodos.ElementAt(0).agergarConexion(nodos.ElementAt(1)); //Ciudad 2
            nodos.ElementAt(0).agergarConexion(nodos.ElementAt(3)); //Ciudad 4

            //Ciudad 2 -> ciudad 3
            nodos.ElementAt(1).agergarConexion(nodos.ElementAt(0)); //Ciudad 1, agregada para el punto e
            nodos.ElementAt(1).agergarConexion(nodos.ElementAt(2)); //Ciudad 3
            nodos.ElementAt(1).agergarConexion(nodos.ElementAt(4)); //Ciudad 5, agregada para el punto d

            //Ciudad 3 -> 

            //Ciudad 4 -> ciudad 5 y 6
            nodos.ElementAt(3).agergarConexion(nodos.ElementAt(4)); //Ciudad 5
            nodos.ElementAt(3).agergarConexion(nodos.ElementAt(5)); //Ciudad 6

            //Ciudad 5 -> ciudad 6
            nodos.ElementAt(4).agergarConexion(nodos.ElementAt(5)); //Ciudad 6

            //Ciudad 6 -> 

        }
        public static void reiniciarPreguntando()   //Ningún nodo preguntando
        {
            foreach (nodo n in nodos)
            {
                n.preguntando = false;
            }
        }
    }
}
