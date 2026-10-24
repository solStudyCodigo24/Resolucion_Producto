using System.Collections.Generic;
using System.Linq;

namespace Gestion_Productos
{
    internal class ProductoRepository : IProductoRepository
    {
        private List<Producto> productos;

        public ProductoRepository()
        {
            productos = new List<Producto>();

            productos.Add(new Producto(1, "Teclado", 15000m, "Informatica", true));
            productos.Add(new Producto(2, "Mouse", 8000m, "Informatica", true));
            productos.Add(new Producto(3, "Silla", 50000m, "Muebles", true));
            productos.Add(new Producto(4, "Escritorio", 80000m, "Muebles", false));
        }

        public void Agregar(Producto productoNuevo)
        {
            productos.Add(productoNuevo);
        }

        public List<Producto> ObtenerTodos()
        {
            return productos.ToList();
        }

        public Producto ObtenerPorId(int idBuscado)
        {
            return productos.FirstOrDefault(
                productoRegistrado => productoRegistrado.Id == idBuscado
            )!;
        }

        public List<Producto> BuscarPorCategoria(string categoriaBuscada)
        {
            return productos
                .Where(
                    productoRegistrado =>
                        productoRegistrado.Categoria == categoriaBuscada
                )
                .ToList();
        }
    }
}