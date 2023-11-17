using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB
{
    public class Node
    {
        public int dato;

        //los punteros izq y der podrian apuntar a null de acuerdo a la cantidad de hijos del nodo
        public Node izquierda;
        public Node derecha;

        public Node(int dato)
        { 
            //constructor que utilizamos para crear un nuevo nodo
            this.dato = dato;

            //izq y der se inicializan como null debido a q el dnodo se crea inicialmente sin hijos
            izquierda = null;
            derecha = null;
        }
    }
}
