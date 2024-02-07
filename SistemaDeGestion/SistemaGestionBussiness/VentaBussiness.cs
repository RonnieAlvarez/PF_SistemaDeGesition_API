using Microsoft.EntityFrameworkCore;
using SistemaDeGestion.database;
using SistemaDeGestion.models;

namespace SistemaDeGestion.service
{
    public class VentaBussiness
    {
        public static Ventum GetVenta(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Ventum? ventaBuscado = context.Venta.Where(p => p.Id == id).FirstOrDefault();
                return ventaBuscado;
            }
        }
        public static List<Ventum> GetVentas()
        {
            using (CoderContext context = new CoderContext())
            {
                List<Ventum> ventas = context.Venta.ToList();
                return ventas;
            }
        }

        public static bool AgregarVenta(Ventum venta)
        {
            if (venta.IdUsuario.Equals(0))
            {
                return false;
            }
            using (CoderContext context = new CoderContext())
            {
                context.Venta.Add(venta);
                context.SaveChanges();
                return true;
            }
        }
        public static bool ActualizarVentaXId(Ventum venta, int Id)
        {
            using (CoderContext context = new CoderContext())
            {
                Ventum? ventaBuscado = GetVenta(Id);
                ventaBuscado.Comentarios = venta.Comentarios;
                ventaBuscado.IdUsuario = venta.IdUsuario;

                context.Venta.Update(ventaBuscado);
                context.SaveChanges();
                return true;
            }
        }


        public static bool EliminarVentaPorId(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Ventum ventaEliminar = context.Venta.Include(p => p.ProductoVendidos).Where(p => p.Id == id).FirstOrDefault();
                if (ventaEliminar is not null)
                {
                    context.Venta.Remove(ventaEliminar);
                    context.SaveChanges();
                    return true;
                    /*
                     * Para poder eliminar registros que estan ligado con forein key se debe usar la 
                     * eliminacion en CASCADA  lo que implica cambiar en el archivo de context 
                     * .OnDelete(DeleteBehavior.SetNull) por  .OnDelete(DeleteBehavior.Cascade)
                     * Ademas debemos agregar el INCLUDE en la sentencia Entity
                     * Venta ventaEliminar = context.Ventas.Where(p => p.Id == id).FirstOrDefault();
                     * Venta ventaEliminar = context.Ventas.Include(p=>p.VentaVendidos).Where(p=>p.Id == id).FirstOrDefault();
                     * */
                }
            }
            return false;
        }
    }
}
