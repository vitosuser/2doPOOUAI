using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActividadCuentaDeBancoVitoTramontini.Modelos;

namespace ActividadCuentaDeBancoVitoTramontini.Repositorios
{
    public class CuentasRepositorio
    {
        private List<CuentaBancaria> cuentas = new List<CuentaBancaria>();

        public void Guardar(CuentaBancaria cuenta)
        {
            cuentas.Add(cuenta);
        }

        public CuentaBancaria? buscarCuenta(string numero) //puede ser nulo si no encuentra ninguna
        {
            return cuentas.Find(cuenta => cuenta.NroCuenta == numero);
        }


    }
}
