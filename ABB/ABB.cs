using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB
{
    internal class ABB
    {
        // Unico atributo de la clase ABB
        public Node raiz;

        public void insert(int valor)
        {
            this.insertRecursive(raiz, valor);
        }

        private Node insertRecursive(Node raiz, int value)
        {
            if (raiz == null) return new Node(value);

            if (value < raiz.dato) raiz.izquierda = insertRecursive(raiz.izquierda, value);
            else if (value > raiz.dato)
            {
                raiz.derecha = insertRecursive(raiz.derecha, value);
            }

            return raiz;
        }

        public void ShowTree(Node node, string prefix = "", bool isLeft = true)
        {
            if (node != null)
            {
                Console.WriteLine($"{prefix} {(isLeft ? "├──" : "└──")} {node.dato}");

                ShowTree(node.izquierda,
                    $"{prefix} {(isLeft ? "│   " : "    ")}",
                    true);

                ShowTree(node.derecha,
                    $"{prefix} {(isLeft ? "│   " : "    ")}",
                    false);
            }
        }
    }
}
