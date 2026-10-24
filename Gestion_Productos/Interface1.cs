using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Productos
{
    internal interface IProductoRepository
    {
       void Agregar(Producto producto);
       List<Producto> ObtenerTodos();
        Producto ObtenerPorId(int id);
       List<Producto> BuscarPorCategoria(string categoria);
    }
}
