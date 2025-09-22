using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad19_poo.Models
{
    class SuperPoder
    {
        public string Nombre;
        public string decripcion;
        public NivelPoder Nivel;

        public SuperPoder()
        {
            Nivel = NivelPoder.niveluno;
        }
    }
}
