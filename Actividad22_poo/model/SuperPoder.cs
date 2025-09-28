using System;                          // Espacio de nombres base de .NET
using System.Text;                     // Funcionalidades para manejo de texto y codificaciones
using System.Threading.Tasks;          // Soporte para tareas asíncronas

namespace Actividad19_poo.Models        // Namespace que organiza las clases del proyecto
{
    // Clase que representa un superpoder de un superhéroe
    class SuperPoder
    {
        public string Nombre;           // Nombre del poder (ej: "Super Fuerza", "Volar")
        public string decripcion;       // Descripción del poder (ej: "Capacidad para volar")
        public NivelPoder Nivel;        // Nivel del poder (enum definido en otro archivo)

        // Constructor por defecto
        public SuperPoder()
        {
            // Se asigna como nivel inicial 'niveluno' al crear cualquier superpoder
            Nivel = NivelPoder.niveluno;
        }
    }
}
