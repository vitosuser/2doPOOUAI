using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaTorneosEsportTramontiniVito.Modelos
{
    public class Partida
    {
        private Equipo equipo1;
        private Equipo equipo2;
        private Estado estadoPartida;

        public Equipo Equipo1 { get => equipo1; set => equipo1 = value; }
        public Equipo Equipo2 { get => equipo2; set => equipo2 = value; }
        public Estado EstadoPartida { get => estadoPartida; set => estadoPartida = value; }
    }
}
