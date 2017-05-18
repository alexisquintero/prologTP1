using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolog
{
    class Program
    {       
        static void Main(string[] args)
        {
            pantallaPrincipal();
            incializarNodos();
            while (true)
            {
                esperarInput();
                string input = Console.ReadLine();
                analizarInput(input);
            }
        }
        static void pantallaPrincipal()
        {
            Console.Write("Welcome to SWI-Prolog# (threaded, 64 bits, version 7.4.1)\n");
            Console.Write("SWI-Prolog comes with ABSOLUTELY NO WARRANTY. This is free software.\n");
            Console.Write("Please run ?- license. for legal details.\n");
            Console.Write("\n");
            Console.Write("For online help and background, visit http://www.swi-prolog.org\n");
            Console.Write("For built-in help, use ?- help(Topic). or ?- apropos(Word).\n");
            Console.Write("\n");
        }
        static void esperarInput()
        {
            Console.Write("?- ");
        }
        static void incializarNodos()
        {
            BaseDeHechos.incializarNodos();
        }
        static void analizarInput(string input)
        {
            if (input.Contains("conexion"))
            {
                string parametros = input.Split('(', ')')[1];
                string[] nodos = parametros.Split(',');
                nodos[0] = nodos[0].Trim();
                nodos[1] = nodos[1].Trim();
                conexion(nodos[0], nodos[1]);
            }
            else
            {
                Console.Write("ERROR: Undefined procedure: " + input + "/0 (DWIM could not correct goal)\n");
                return;
            }
        }
        static void conexion(string nodoInicio, string nodoFin)
        {
            BaseDeHechos.reiniciarPreguntando();    //Inicio de la consulta, ningún nodo está preguntando todavía

            foreach (nodo n in BaseDeHechos.nodos)
            {
                if (string.Equals(n.nombre, nodoInicio))
                {
                    if (n.conectado(nodoFin))
                    {
                        Console.Write("True.\n");
                    }
                    else
                    {
                        Console.Write("False.\n");
                    }
                }
            }
        }
    }
}
