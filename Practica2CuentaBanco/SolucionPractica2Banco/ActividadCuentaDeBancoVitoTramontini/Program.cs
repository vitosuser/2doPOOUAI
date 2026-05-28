using ActividadCuentaDeBancoVitoTramontini.Modelos;
using ActividadCuentaDeBancoVitoTramontini.Repositorios;
using ActividadCuentaDeBancoVitoTramontini.Excepciones;

namespace ActividadCuentaDeBancoVitoTramontini
{
    internal class Program
    {
        static CuentasRepositorio repo = new CuentasRepositorio();
        static Banco banco = new Banco(repo);

        static void Main(string[] args)
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("          SISTEMA BANCARIO              ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Crear Cuenta de Ahorros");
                Console.WriteLine("2. Crear Cuenta Corriente");
                Console.WriteLine("3. Realizar Depósito");
                Console.WriteLine("4. Realizar Retiro");
                Console.WriteLine("5. Consultar Saldo");
                Console.WriteLine("6. Salir");
                Console.WriteLine("========================================");
                Console.Write("Seleccione una opción: ");
                int opcion;


                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    continue;
                }

                Console.WriteLine();
                try
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("--- CREAR CUENTA DE AHORROS ---");
                            CuentaAhorros nuevaAhorros = new CuentaAhorros();

                            //pido nroCuenta
                            Console.WriteLine("Ingrese un numero de cuenta: ");
                            string nroCuentaAhorro = Console.ReadLine();
                            if (!int.TryParse(nroCuentaAhorro, out _))
                            {
                                throw new DatosInvalidosExcepcion("Error: Debe ingresar unicamente numeros enteros en el numero de cuenta");
                            }

                            nuevaAhorros.NroCuenta = nroCuentaAhorro;

                            //pido titularCuenta
                            Console.WriteLine("Titular: ");
                            string titularAhorro = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(titularAhorro))
                            {
                                throw new DatosInvalidosExcepcion("Error: Debe ingresar un nombre de titular valido");
                            }

                            nuevaAhorros.Titular = titularAhorro;

                            //asigno saldo 0
                            nuevaAhorros.Saldo = 0;

                            banco.AgregarCuenta(nuevaAhorros);

                            Console.WriteLine("Cuenta de Ahorros creada con exito");

                            break;



                        case 2:
                            Console.WriteLine("--- CREAR CUENTA CORRIENTE ---");
                            CuentaCorriente nuevaCorriente = new CuentaCorriente();

                            Console.WriteLine("Ingrese un numero de cuenta: ");
                            string nroCuentaCor = Console.ReadLine();
                            if (!int.TryParse(nroCuentaCor, out _))
                            {
                                throw new DatosInvalidosExcepcion("Error: Debe ingresar unicamente numeros enteros en el numero de cuenta");
                            }

                            nuevaCorriente.NroCuenta = nroCuentaCor;

                            Console.WriteLine("Titular: ");
                            string titularCor = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(titularCor))
                            {
                                throw new DatosInvalidosExcepcion("Error: Debe ingresar un nombre de titular valido");
                            }

                            nuevaCorriente.Titular = titularCor;

                            nuevaCorriente.Saldo = 0;

                            banco.AgregarCuenta(nuevaCorriente);

                            Console.WriteLine("Cuenta Corriente creada con exito");

                            break;

                        case 3:
                            Console.WriteLine("--- REALIZAR DEPÓSITO ---");

                            Console.WriteLine("Numero de cuenta a la que desea depositar: ");
                            string cuentaBuscarDep = Console.ReadLine();
                            if (string.IsNullOrEmpty(cuentaBuscarDep))
                            {
                                throw new DatosInvalidosExcepcion("Error: El numero de cuenta no puede estar vacio");

                            }

                            CuentaBancaria cuentaDepositar = banco.BuscarCuenta(cuentaBuscarDep);

                            Console.WriteLine($"Cuenta encontrada. \nTitular: {cuentaDepositar.Titular} \nSaldo: {cuentaDepositar.Saldo}");
                            Console.WriteLine("\nMonto a depositar: ");

                            double montoDep;
                            if (!double.TryParse(Console.ReadLine(), out montoDep))
                            {
                                throw new DatosInvalidosExcepcion("Error: Ingrese un monto a depositar valido");
                            }

                            cuentaDepositar.Depositar(montoDep);

                            Console.WriteLine("Deposito realizado con exito");

                            break;

                        case 4:
                            Console.WriteLine("--- REALIZAR RETIRO ---");
                            Console.WriteLine("Numero de cuenta a retirar: ");

                            string cuentaBuscarRet = Console.ReadLine();
                            if (string.IsNullOrEmpty(cuentaBuscarRet))
                            {
                                throw new DatosInvalidosExcepcion("Error: El numero de cuenta no puede estar vacio");

                            }


                            CuentaBancaria cuentaRetirar = banco.BuscarCuenta(cuentaBuscarRet);

                            Console.WriteLine($"Cuenta encontrada. \nTitular: {cuentaRetirar.Titular} \nSaldo: {cuentaRetirar.Saldo}");
                            Console.WriteLine("\nMonto a retirar: ");

                            double montoRet;
                            if (!double.TryParse(Console.ReadLine(), out montoRet))
                            {
                                throw new DatosInvalidosExcepcion("Error: Ingrese un monto a depositar valido");
                            }

                            cuentaRetirar.Retirar(montoRet);

                            Console.WriteLine("\nRetiro realizado con exito");


                            break;

                        case 5:
                            Console.WriteLine("--- CONSULTAR SALDO ---");

                            Console.WriteLine("Numero de cuenta: ");
                            string cuentaConsultar = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(cuentaConsultar))
                            {
                                throw new DatosInvalidosExcepcion("Error: El numero de cuenta no puede estar vacio");

                            }

                            CuentaBancaria cuenta = banco.BuscarCuenta(cuentaConsultar);

                            Console.WriteLine(cuenta.ConsultarSaldo());

                            break;

                        case 6:
                            salir = true;
                            Console.WriteLine("Cerrando el sistema.");
                            break;

                        default:
                            Console.WriteLine("Opción no válida. Por favor, seleccione un número del 1 al 6.");
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"\n{ex.Message}");
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
            } while (!salir);

        }
    }
}
