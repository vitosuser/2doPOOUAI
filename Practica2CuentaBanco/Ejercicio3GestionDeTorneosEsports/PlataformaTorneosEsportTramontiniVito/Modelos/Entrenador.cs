using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaTorneosEsportTramontiniVito.Modelos
{
    public class Entrenador
    {
        private string nombreEntrenador;
        private int aniosExperiencia;

        public string NombreEntrenador { get => nombreEntrenador; set => nombreEntrenador = value; }
        public int AniosExperiencia { get => aniosExperiencia; set => aniosExperiencia = value; }
    }
}
