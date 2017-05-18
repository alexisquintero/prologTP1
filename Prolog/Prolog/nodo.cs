using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolog
{
    class nodo
    {
        public bool preguntando = false;    //Indica si este nodo ya está realizando una pregunta a otro nodo, para evitar bucles
        public List<nodo> conexiones = new List<nodo>();     //Conjunto de nodos a los que está conectado
        public string nombre;
        public nodo(string nom)
        {
            nombre = nom;
        }
        public bool conectado(string nombreNodo)
        {
            bool respuesta = false;
            if (!preguntando)   //Si no estoy preguntando ya 
	        {              
                preguntando = true; //cambiar estado de preguntando
                foreach (nodo n1 in conexiones)//preguntar a las conexiones si son nombreNodo 
                {
                    if (string.Equals(nombreNodo, n1.nombre))
                    {
                        respuesta = true;
                    }
                }
                if (!respuesta) //si no preguntar si están conectadas a nombreNodo
                {
                    foreach (nodo n2 in conexiones)
                    {
                        if (n2.conectado(nombreNodo))
                        {
                            respuesta = true;
                        }
                    }
                } 
            }
            return respuesta;
        }
        public void agergarConexion(nodo n)
        {
            conexiones.Add(n);
        }
    }
}
