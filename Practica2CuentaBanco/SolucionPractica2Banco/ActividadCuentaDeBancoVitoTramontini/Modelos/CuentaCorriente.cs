using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (Saldo + maxSobregiro < monto)
            {
                throw new Exception($"Fondos insuficientes.Esta cuenta corriente permite un sobregiro máximo de ${maxSobregiro}");
            }

            base.Retirar(monto);

        }
    }
}
