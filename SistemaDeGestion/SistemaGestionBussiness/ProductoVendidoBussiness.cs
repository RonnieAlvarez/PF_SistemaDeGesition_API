using Microsoft.EntityFrameworkCore;
using SistemaDeGestion.database;
using SistemaDeGestion.models;

namespace SistemaDeGestion.service
{
    public class ProductoVendidoBussiness
    {
        public static ProductoVendido GetProductoVendido(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                ProductoVendido? productoBuscado = context.ProductoVendidos.Where(p => p.Id == id).FirstOrDefault();
                return productoBuscado;
            }
        }
        public static List<ProductoVendido> GetProductoVendidosVendidos()
        {
            using (CoderContext context = new CoderContext())
            {
                List<ProductoVendido> productosVendidos = context.ProductoVendidos.ToList();
                return productosVendidos;
            }
        }

        public static bool AgregarProductoVendido(ProductoVendido producto)
        {
            if (producto.IdVenta.Equals(0))
            {
                return false;
            }
            using (CoderContext context = new CoderContext())
            {
                context.ProductoVendidos.Add(producto);
                context.SaveChanges();
                return true;
            }
        }
        public static bool ActualizarProductoVendidoXId(ProductoVendido producto, int Id)
        {
            using (CoderContext context = new CoderContext())
            {
                ProductoVendido? productoBuscado = GetProductoVendido(Id);
                productoBuscado.Stock = producto.Stock;
                productoBuscado.IdProducto = producto.IdProducto;
                productoBuscado.IdVenta = producto.IdVenta;

                context.ProductoVendidos.Update(productoBuscado);
                context.SaveChanges();
                return true;
            }
        }


        public static bool EliminarProductoVendidoPorId(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                ProductoVendido productoEliminar = context.ProductoVendidos.Include(p => p.IdVenta).Where(p => p.Id == id).FirstOrDefault();
                if (productoEliminar is not null)
                {
                    context.ProductoVendidos.Remove(productoEliminar);
                    context.SaveChanges();
                    return true;
                    /*
                     * Para poder eliminar registros que estan ligado con forein key se debe usar la 
                     * eliminacion en CASCADA  lo que implica cambiar en el archivo de context 
                     * .OnDelete(DeleteBehavior.SetNull) por  .OnDelete(DeleteBehavior.Cascade)
                     * Ademas debemos agregar el INCLUDE en la sentencia Entity
                     * ProductoVendido productoEliminar = context.ProductoVendidos.Where(p => p.Id == id).FirstOrDefault();
                     * ProductoVendido productoEliminar = context.ProductoVendidos.Include(p=>p.ProductoVendidos).Where(p=>p.Id == id).FirstOrDefault();
                     * */
                }
            }
            return false;
        }
    }
}
