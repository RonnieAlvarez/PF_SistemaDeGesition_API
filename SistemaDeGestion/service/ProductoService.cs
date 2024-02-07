using Microsoft.EntityFrameworkCore;
using SistemaDeGestion.database;
using SistemaDeGestion.models;

namespace SistemaDeGestion.service
{
    public static class ProductoService
    {
        public static Producto GetProducto(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Producto? productoBuscado = context.Productos.Where(p => p.Id == id).FirstOrDefault();
                return productoBuscado;
            }
        }
        public static List<Producto> GetProductos()
        {
            using (CoderContext context = new CoderContext())
            {
                List<Producto> productos = context.Productos.ToList();
                return productos;
            }
        }

        public static bool AgregarProducto(Producto producto)
        {
            if (producto.PrecioVenta.Equals(0))
            {
                return false;
            }
            using (CoderContext context = new CoderContext())
            {
                context.Productos.Add(producto);
                context.SaveChanges();
                return true;
            }
        }
        public static bool ActualizarProductoXId(Producto producto, int Id)
        {
            using (CoderContext context = new CoderContext())
            {
                Producto? productoBuscado = GetProducto(Id);
                productoBuscado.Descripciones = producto.Descripciones;
                productoBuscado.Costo = producto.Costo;
                productoBuscado.PrecioVenta = producto.PrecioVenta;
                productoBuscado.Stock = producto.Stock;
                productoBuscado.IdUsuario = producto.IdUsuario;

                context.Productos.Update(productoBuscado);
                context.SaveChanges();
                return true;
            }
        }


        public static bool EliminarProductoPorId(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Producto productoEliminar = context.Productos.Include(p => p.ProductoVendidos).Where(p => p.Id == id).FirstOrDefault();
                if (productoEliminar is not null)
                {
                    context.Productos.Remove(productoEliminar);
                    context.SaveChanges();
                    return true;
                    /*
                     * Para poder eliminar registros que estan ligado con forein key se debe usar la 
                     * eliminacion en CASCADA  lo que implica cambiar en el archivo de context 
                     * .OnDelete(DeleteBehavior.SetNull) por  .OnDelete(DeleteBehavior.Cascade)
                     * Ademas debemos agregar el INCLUDE en la sentencia Entity
                     * Producto productoEliminar = context.Productos.Where(p => p.Id == id).FirstOrDefault();
                     * Producto productoEliminar = context.Productos.Include(p=>p.ProductoVendidos).Where(p=>p.Id == id).FirstOrDefault();
                     * */
                }
            }
            return false;
        }
    }
}
