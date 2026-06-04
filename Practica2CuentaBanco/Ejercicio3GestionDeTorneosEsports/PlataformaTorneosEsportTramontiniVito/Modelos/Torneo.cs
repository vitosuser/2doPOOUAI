using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaTorneosEsportTramontiniVito.Modelos
{
    public class Torneo
    {
        private string nombre;
        private Juego juego;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string premio;
        private Estado estado;
        private Formato formato;
        private List<Partida> listaPartidas;

        public Torneo()
        {
            ListaPartidas = new List<Partida>();

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public Juego Juego { get => juego; set => juego = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public string Premio { get => premio; set => premio = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public Formato Formato { get => formato; set => formato = value; }
        public List<Partida> ListaPartidas { get => listaPartidas; set => listaPartidas = value; }


    }
}
