using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaTorneosEsportTramontiniVito.Modelos
{
    public class Jugador
    {
        private string userName;
        private Rango rango;
        private Region region;

        public string UserName { get => userName; set => userName = value; }
        public Rango Rango { get => rango; set => rango = value; }
        public Region Region { get => region; set => region = value; }
    }
}
