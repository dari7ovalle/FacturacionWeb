using SisAgroVeterinaria.DAL;
using SisAgroVeterinaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SisAgroVeterinaria.BLL
{
    public class VentaDetallesBLL
    {
        public static bool Guardar(VentaDetalles ventaDetalles)
        {
            bool estado = false;
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.ventaDetalles.Add(ventaDetalles);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;

        }
        public static bool Editar(VentaDetalles ventaDetalles)
        {
            bool estado = false;

            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.Entry(ventaDetalles).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }
        public static VentaDetalles Buscar(int Id)
        {
            VentaDetalles ventaDetalles = new VentaDetalles();
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                ventaDetalles = context.ventaDetalles.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

            return ventaDetalles;

        }

        public static bool Eliminar(int VentaDetallesId)
        {
            VentaDetalles ventaDetalle = null;
            bool estado = false;
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                ventaDetalle = context.ventaDetalles.Find(VentaDetallesId);
                context.ventaDetalles.Remove(ventaDetalle);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }

        public static List<VentaDetalles> GetList(Expression<Func<VentaDetalles, bool>> criterioBusqueda)
        {
            List<VentaDetalles> ventaDetalle = new List<VentaDetalles>();
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                ventaDetalle = context.ventaDetalles.Where(criterioBusqueda).ToList();
            }

            catch (Exception)
            {
                throw;
            }

            return ventaDetalle;
        }





    }




}

