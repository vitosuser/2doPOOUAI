using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActividadCuentaDeBancoVitoTramontini.Excepciones;

namespace ActividadCuentaDeBancoVitoTramontini.Modelos
{
    public class CuentaAhorros : CuentaBancaria
    {
        private int retirosMesActual;
        public int RetirosMesActual { get { return retirosMesActual; } set { retirosMesActual = value; } }

        public CuentaAhorros() : base() 
        {
            retirosMesActual = 0;
        }

        public override void Retirar(double monto)
        {
            if(retirosMesActual >= 3)
            {
                throw new LimiteDeRetirosExcedidoExcepcion("Se alcanzo el límite máximo de 3 retiros mensuales.");
            }

            base.Retirar(monto);

            retirosMesActual = retirosMesActual + 1;
        }
    }
}
