using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadCuentaDeBancoVitoTramontini.Excepciones
{
    public class DatosInvalidosExcepcion : Exception
    {
        public DatosInvalidosExcepcion(string mensaje) : base(mensaje) { }
    }

}
