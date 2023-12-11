using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRexman
{

    public class Metodos
    {
        public string[] productos = new string[10];
        public double[] precios = new double[10];
        public int cantidadProductos = 0;
        public void Insertar()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            double precio;
            if (!double.TryParse(Console.ReadLine(), out precio))
            {
                Console.WriteLine("No sirve ese Precio.");
                return;
            }

            int indice = 0;
            while (indice < cantidadProductos && precios[indice] < precio)
            {
                indice++;
            }

            for (int i = cantidadProductos - 1; i >= indice; i--)
            {
                productos[i + 1] = productos[i];
                precios[i + 1] = precios[i];
            }

            productos[indice] = nombre;
            precios[indice] = precio;
            cantidadProductos++;

            Console.WriteLine("Ya se agrego tu Producto.");
        }
        public void Mostrar()
        {
            if (cantidadProductos == 0)
            {
                Console.WriteLine("No hay productos en el inventario.");
                return;
            }

            Console.WriteLine("Productos en el inventario:");
            for (int i = 0; i < cantidadProductos; i++)
            {
                Console.WriteLine($"{productos[i]} - ${precios[i]}");
            }
        }
        public void Ordenar()
        {

            Console.WriteLine("\n");
            Console.WriteLine("NO supe como ordenar pipipi");
            Console.WriteLine("\n");
        }
        public void Buscar()
        {
            Console.Write("Ingrese el precio a buscar: ");
            double precio;
            if (!double.TryParse(Console.ReadLine(), out precio))
            {
                Console.WriteLine("Precio no válido. Intente nuevamente.");
                return;
            }
            bool encontrado = false;
            Console.WriteLine($"");
            for (int i = 0; i < cantidadProductos; i++)
            {
                if (precios[i] == precio)
                {

                    Console.WriteLine($"{productos[i]}-${precios[i]}");
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("No se encontrarton productos:");
            }


        }



    }
}