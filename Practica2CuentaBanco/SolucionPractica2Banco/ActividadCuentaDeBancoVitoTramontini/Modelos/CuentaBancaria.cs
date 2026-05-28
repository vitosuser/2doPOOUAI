using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActividadCuentaDeBancoVitoTramontini.Excepciones;

namespace ActividadCuentaDeBancoVitoTramontini.Modelos
{
    public abstract class CuentaBancaria
    {
        private string nroCuenta;
        private string titular;
        protected double saldo; //para q pueda ser modificado por clases hijas

        public string NroCuenta { get => nroCuenta; set => nroCuenta = value; }
        public string Titular { get => titular; set => titular = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public CuentaBancaria()
        {

        }

        public virtual void Depositar(double monto)
        {
            if(monto <= 0)
            {
                throw new DatosInvalidosExcepcion("El monto a depositar debe ser mayo a cero.");
            }

            saldo = saldo + monto;

        }
        public virtual void Retirar(double monto)
        {
            if(monto > saldo)
            {
                throw new FondosInsuficientesExcepcion("Fondos insuficientes para realizar el retiro.");
            }

            saldo = saldo - monto;


        }
        public string ConsultarSaldo()
        {
            return $"Informacion cuenta:\n-Nro de cuenta: {NroCuenta}.\n-Titular: {Titular}.\n-Saldo: ${Saldo}.";
        }
    }
}
