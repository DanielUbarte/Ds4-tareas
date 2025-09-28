using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad22_poo.model
{
    internal abstract class Heroe
    {
        public abstract string Nombre { get; set; }
        public abstract string SalvarElMundo();

        public string SalvarLaTierra()
        {
        return $"{Nombre} está salvando la tierra!!";
        }
    }
}
