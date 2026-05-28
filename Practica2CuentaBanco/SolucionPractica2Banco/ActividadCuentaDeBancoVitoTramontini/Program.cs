namespace ActividadCuentaDeBancoVitoTramontini
{
    internal class Program
    {
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

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("--- CREAR CUENTA DE AHORROS ---");
                        // Aquí pediremos los datos por consola e instaciaremos la clase.
                        // Recordatorio: NO sobrecargar el constructor con todos los atributos.
                        break;

                    case 2:
                        Console.WriteLine("--- CREAR CUENTA CORRIENTE ---");
                        // Lógica de creación de cuenta corriente
                        break;

                    case 3:
                        Console.WriteLine("--- REALIZAR DEPÓSITO ---");

                        // Pedir número de cuenta y monto, luego llamar a banco.Depositar()
                        break;

                    case 4:
                        Console.WriteLine("--- REALIZAR RETIRO ---");
                        // Pedir número de cuenta y monto, luego llamar a banco.Retirar()
                        break;

                    case 5:
                        Console.WriteLine("--- CONSULTAR SALDO ---");
                        // Pedir número de cuenta y mostrar detalles
                        break;

                    case 6:
                        salir = true;
                        Console.WriteLine("Cerrando el sistema.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione un número del 1 al 6.");
                        break;
                }
            } while (!salir);
            
        }
    }
}
