using System;
using System.Collections.Generic;

namespace HR_EX_FINAL
{
    public class Grafo
    {
        private Dictionary<string, List<string>> _listaUsuariosRedSocial;

        public Grafo()
        {
            // Se crea instancia de la misma
            _listaUsuariosRedSocial = new Dictionary<string, List<string>>();
        }

        /// <summary>
        /// Método para cargar todos los usuarios
        /// </summary>
        /// <param name="usuarios">Lista de usuario de archivo</param>
        public void CargarUsuarios(string[] usuarios)
        {
            // Recorremos el array string
            foreach (string usuario in usuarios)
            {
                // Insertamos en el grafo con la lista se string vacía
                _listaUsuariosRedSocial.Add(usuario, new List<string>());
            }
        }

        /// <summary>
        /// Método para enlazar amistad entre dos usuarios
        /// </summary>
        /// <param name="persona1">Usuario uno</param>
        /// <param name="persona2">Usuario dos</param>
        public void GenerarAmistad(string persona1, string persona2)
        {
            // Se verifica si persona2 ya es amigo de persona1 antes de agregarlo
            if (!_listaUsuariosRedSocial[persona1].Contains(persona2))
            {
                _listaUsuariosRedSocial[persona1].Add(persona2);
            }

            // Se verifica si persona1 ya es amigo de persona2 antes de agregarlo
            if (!_listaUsuariosRedSocial[persona2].Contains(persona1))
            {
                _listaUsuariosRedSocial[persona2].Add(persona1);
            }
        }

        /// <summary>
        /// Método para mostrar las relaciones de amigos de los usuarios
        /// </summary>
        public void MostrarAmigos()
        {
            foreach (var kvp in _listaUsuariosRedSocial)
            {
                Console.WriteLine($"El usuario {kvp.Key} tiene de amigos a: {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
