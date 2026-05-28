using ActividadCuentaDeBancoVitoTramontini.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ActividadCuentaDeBancoVitoTramontini.Modelos
{
    public class Banco
    {
        private CuentasRepositorio repositorio;
        public Banco(CuentasRepositorio repositorioCuentas) 
        {
            repositorio = repositorioCuentas; //indico que repositorio de cuentas voy a usar, en este caso solo tengo 1
        }

        public void AgregarCuenta(CuentaBancaria cuenta)
        {
            string nroNuevaCuenta = cuenta.NroCuenta;
            if(repositorio.buscarCuenta(nroNuevaCuenta) != null)
            {
                throw new Exception("Ya existe una cuenta registrada con ese número");
            }

            repositorio.Guardar(cuenta);
        }

        public CuentaBancaria BuscarCuenta(string numeroCuenta)
        {
            CuentaBancaria? cuenta = repositorio.buscarCuenta(numeroCuenta);

            if (cuenta == null)
            {
                throw new Exception($"El numero de cuenta: {numeroCuenta} no existe en el repositorio de cuentas");
            }

            return cuenta;
        }
    }
}
