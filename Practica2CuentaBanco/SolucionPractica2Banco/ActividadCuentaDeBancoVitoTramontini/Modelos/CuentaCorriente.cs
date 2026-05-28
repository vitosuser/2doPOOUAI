using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActividadCuentaDeBancoVitoTramontini.Excepciones;


namespace ActividadCuentaDeBancoVitoTramontini.Modelos
{
    public class CuentaCorriente : CuentaBancaria
    {
        private int maxSobregiro = 100000;

        public CuentaCorriente() : base()
        {
        }

        public override void Retirar(double monto)
        {
            if(monto <= 0)
            {
                throw new DatosInvalidosExcepcion("Error: Debe ingresar un monto mayor a cero para retirar");
            }
            if (Saldo + maxSobregiro < monto)
            {
                throw new FondosInsuficientesExcepcion($"Fondos insuficientes.Esta cuenta corriente permite un sobregiro máximo de ${maxSobregiro}");
            }

            saldo = saldo - monto;

        }
    }
}
