using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaTorneosEsportTramontiniVito.Modelos
{
    public class Equipo
    {
        private string nombreEquipo;
        private List<Jugador> listaJugadores;
        private Entrenador entrenador;

        public Equipo() 
        {
            listaJugadores = null;
        }

        public List<Jugador> ListaJugadores { get => listaJugadores; set => listaJugadores = value; }
        public Entrenador Entrenador { get => entrenador; set => entrenador = value; }
        public string NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }
    }
}
