using System;

namespace Gestion_Productos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Crear repositorio
                IProductoRepository repositorio = new ProductoRepository();

                Console.WriteLine("===== LISTA DE PRODUCTOS =====");

                foreach (Producto productoActual in repositorio.ObtenerTodos())
                {
                    Console.WriteLine(
                        $"ID: {productoActual.Id} | " +
                        $"Nombre: {productoActual.Nombre} | " +
                        $"Precio: ${productoActual.Precio} | " +
                        $"Categoria: {productoActual.Categoria} | " +
                        $"Activo: {productoActual.Activo}"
                    );
                }

                Console.WriteLine();
                Console.WriteLine("===== BUSQUEDA POR ID =====");

                Producto productoEncontrado = repositorio.ObtenerPorId(2);

                if (productoEncontrado != null)
                {
                    Console.WriteLine(
                        $"Producto encontrado: {productoEncontrado.Nombre}"
                    );
                }
                else
                {
                    Console.WriteLine("No se encontró un producto con ese ID.");
                }

                Console.WriteLine();
                Console.WriteLine("===== BUSQUEDA POR CATEGORIA =====");

                foreach (Producto productoCategoria in repositorio.BuscarPorCategoria("Informatica"))
                {
                    Console.WriteLine(productoCategoria.Nombre);
                }

                Console.WriteLine();
                Console.WriteLine("===== AGREGAR PRODUCTO =====");

                Producto nuevoProducto = new Producto(
                    5,
                    "Monitor",
                    120000m,
                    "Informatica",
                    true
                );

                repositorio.Agregar(nuevoProducto);

                Console.WriteLine("Producto agregado correctamente.");

                Console.WriteLine();
                Console.WriteLine("===== LISTA ACTUALIZADA =====");

                foreach (Producto productoActual in repositorio.ObtenerTodos())
                {
                    Console.WriteLine(
                        $"{productoActual.Id} - {productoActual.Nombre}"
                    );
                }
            }
            catch (Exception excepcion)
            {
                Console.WriteLine("Ocurrió un error:");
                Console.WriteLine(excepcion.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
