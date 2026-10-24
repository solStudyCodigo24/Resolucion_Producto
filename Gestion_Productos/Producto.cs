using System;

namespace Gestion_Productos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public bool Activo { get; set; }

        // Constructor vacío (útil si luego agregas con auto-incremento de ID)
        public Producto() { }

        // Constructor con parámetros
        public Producto(int p_Id, string p_Nombre, decimal p_Precio, string p_Categoria, bool p_Activo)
        {
            Id = p_Id;
            Nombre = p_Nombre;
            Precio = p_Precio;
            Categoria = p_Categoria;
            Activo = p_Activo;
        }
    }
}