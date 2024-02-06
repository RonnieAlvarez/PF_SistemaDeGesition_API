using SistemaDeGestion.database;
using SistemaDeGestion.models;

namespace SistemaDeGestion.service
{
    public static class ProductoService
    {
        /*public static bool EliminarProductoPorId(int id)
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
       //         }
     //       }
        //    return false;
        //}

    }
}
