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
   public class TipoProductoBLL
    {
        public static bool Guardar(TipoProductos tipoProductos)
        {
            bool estado = false;
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.tipoProductos.Add(tipoProductos);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;

        }
        public static bool Editar(TipoProductos tipoProductos)
        {
            bool estado = false;

            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.Entry(tipoProductos).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }
        public static TipoProductos Buscar(int Id)
        {
            TipoProductos tipoProductos = new TipoProductos();
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                tipoProductos = context.tipoProductos.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

            return tipoProductos;

        }

        public static bool Eliminar(int ProductoId)
        {
            TipoProductos tipoProducto = null;
            bool estado = false;
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                tipoProducto = context.tipoProductos.Find(ProductoId);
                context.tipoProductos.Remove(tipoProducto);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }

        public static List<TipoProductos> GetList(Expression<Func<TipoProductos, bool>> criterioBusqueda)
        {
            List<TipoProductos> tipoproducto = new List<TipoProductos>();
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                tipoproducto = context.tipoProductos.Where(criterioBusqueda).ToList();
            }

            catch (Exception)
            {
                throw;
            }

            return tipoproducto;
        }

        public static List<TipoProductos> GetList()
        {
            var lista = new List<TipoProductos>();
            SisAgroveterinariaDb context = new SisAgroveterinariaDb();

            try
            {
                lista = context.tipoProductos.ToList();
            }
            catch (Exception e)
            {
                lista = null;
            }

            return lista;
        }


        public static List<TipoProductos> GetTipoProductosNombre(string nombre)
        {
            List<TipoProductos> lista = new List<TipoProductos>();
            SisAgroveterinariaDb context = new SisAgroveterinariaDb();
            lista = context.tipoProductos.Where(c => c.Nombres == nombre).ToList();
            return lista;
        }
        
        public static List<TipoProductos> ListarTodo()
        {
            List<TipoProductos> lista = null;
            SisAgroveterinariaDb context = new SisAgroveterinariaDb();

            lista = context.tipoProductos.ToList();


            return lista;
        }



    }

}

