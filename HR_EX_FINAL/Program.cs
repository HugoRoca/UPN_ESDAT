using System;
using System.IO;
using System.Text;

namespace HR_EX_FINAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obtener la carpeta del archivo ejecutable
            string carpetaEjecutable = AppDomain.CurrentDomain.BaseDirectory;

            // Combinar la carpeta con el nombre del archivo
            string rutaUsuario = Path.Combine(carpetaEjecutable, "Usuarios.txt");
            string rutaAmistades = Path.Combine(carpetaEjecutable, "Amistades.txt");

            // Se establece enconding a UTF-8 para obtener las tildes
            Encoding encoding = Encoding.GetEncoding("ISO-8859-1");

            // Se realiza instancia de la clase Grafo
            Grafo grafo = new Grafo();

            // Leer usuarios del archivo Usuarios.txt y agregarlos al grafo.
            string[] usuarios = File.ReadAllLines(rutaUsuario, encoding);

            // Cargar usuarios
            grafo.CargarUsuarios(usuarios);

            // Cargar realaciones
            string[] amistades = File.ReadAllLines(rutaAmistades, encoding);

            // Variable auxiliar
            string persona1 = null;

            // Se recorre la lista de amistades
            foreach (var lines in amistades)
            {
                // Verificar si la línea actual indica el fin de una pareja de amistades
                if (lines == "***") persona1 = null; // Restablecer la primera persona para la próxima pareja de amistades.
                else
                {
                    // Si la línea no es "***", significa que es un nombre de persona.
                    // Si la primera persona de la pareja no está establecida, asignar la línea actual a persona1.
                    if (persona1 == null) persona1 = lines;
                    else
                    {
                        // Si ya tenemos la primera persona, establecer una relación de amistad en el grafo.
                        grafo.GenerarAmistad(persona1, lines);
                    }
                }
            }

            // Mostramos la lista
            grafo.MostrarAmigos();

            Console.ReadKey();
        }
    }
}
