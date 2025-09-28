using Actividad21_poo.model;
using System;                           // Espacio de nombres base de .NET
using System.Collections.Generic;       // Para usar List<T>
using System.Text;                      // Para usar StringBuilder


namespace Actividad19_poo.Models         // Namespace donde está contenida la clase
{
    // Clase que representa a un Superhéroe
    class SuperHeroe
    {
        private string _Nombre; // Campo privado para el nombre del héroe
        public int ID;                   // Identificador único del héroe
        public string Nombre
        {
            get
            {
                return _Nombre; // Retorna el nombre almacenado
            }
            set
            {
                _Nombre = value.Trim(); // Elimina espacios en blanco al inicio y final
            }
        }
        // Nombre del superhéroe (ej: "Superman")
        public string NombreEIdentidadSecreta
        {
            get
            {
                return $"{Nombre} ({IdentidadSecreta})"; // Combina nombre e identidad secreta
            }
        }
        public string IdentidadSecreta;  // Identidad secreta (ej: "Clark Kent")
        public string Ciudad;            // Ciudad donde actúa el héroe
        public List<SuperPoder> SuperPoderes; // Lista de poderes asociados al héroe
        public bool PuedeVolar;          // Indica si el héroe tiene la habilidad de volar

        // Constructor por defecto
        public SuperHeroe()
        {
            ID = 1;                      // Valor inicial del ID
            SuperPoderes = new List<SuperPoder>(); // Inicializa la lista de poderes vacía
            PuedeVolar = false;          // Por defecto, se asume que no puede volar
        }

        // Método que permite al héroe "usar" sus superpoderes
        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder(); // Objeto para construir cadenas dinámicamente
            foreach (var item in SuperPoderes)      // Recorre cada superpoder asignado
            {
                // Agrega una línea de texto indicando que está usando dicho poder
                sb.AppendLine($"{NombreEIdentidadSecreta} esta usando el super poder {item.Nombre}!!");
            }
            return sb.ToString();       // Devuelve el listado de frases en un solo string
        }

        public string RealizarAccionDeHeroe(string accion2)
        {
            return $"El Super heroe {NombreEIdentidadSecreta} ha realizado {accion2}";
        }
    }
}
