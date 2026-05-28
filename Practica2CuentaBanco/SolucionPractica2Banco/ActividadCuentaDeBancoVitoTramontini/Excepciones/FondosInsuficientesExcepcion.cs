using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadCuentaDeBancoVitoTramontini.Excepciones
{
    public class FondosInsuficientesExcepcion : Exception
    {
        public FondosInsuficientesExcepcion(string mensaje) : base(mensaje) { }
    }

}
