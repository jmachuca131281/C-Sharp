using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto12.Models
{
    public class Persona
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public float Peso { get; set; }
        public bool Trabaja { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
