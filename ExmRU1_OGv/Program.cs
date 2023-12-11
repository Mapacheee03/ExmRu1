using PracticaRexman;
namespace ExmRU1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Metodos metodos = new Metodos();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Bienvenido al sistema de inventario");
                Console.WriteLine("1. Insertar ");
                Console.WriteLine("2. Mostrar ");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Ordenar");
                Console.WriteLine("5. Salir");
                Console.Write("Por favor, seleccione una opción: ");

                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            metodos.Insertar();
                            break;
                        case 2:
                            metodos.Mostrar();
                            break;
                        case 3:
                            metodos.Buscar();
                            break;
                        case 4:
                            metodos.Ordenar();
                            break;
                        case 5:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elije bien tu opcion apa.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Xd solo me falta ordenar.");
                }

                Console.WriteLine();
            }
        }
    }
}