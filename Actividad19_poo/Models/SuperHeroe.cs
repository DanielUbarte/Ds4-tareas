using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad19_poo.Models
{
    class SuperHero
    {
        public int ID;
        public string Nombre;
        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        public SuperHero()
        {
            ID = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }
        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{Nombre} esta usando el super poder {item.Nombre}!!");
            }
            return sb.ToString();
        }
    }
}
