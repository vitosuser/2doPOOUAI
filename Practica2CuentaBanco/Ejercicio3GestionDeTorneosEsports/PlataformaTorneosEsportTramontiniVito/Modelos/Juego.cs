using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaTorneosEsportTramontiniVito.Modelos
{
    public class Juego
    {
        private string nombreJuego;
        private CategoriaJuego categoria;
        private int cantJugadoresPorEquipo;

        public string NombreJuego { get => nombreJuego; set => nombreJuego = value; }
        public CategoriaJuego Categoria { get => categoria; set => categoria = value; }
        public int CantJugadoresPorEquipo { get => cantJugadoresPorEquipo; set => cantJugadoresPorEquipo = value; }
    }
}
