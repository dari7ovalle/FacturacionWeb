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
   public class ProductosBLL
    {
        public static bool Guardar(Productos productos)
        {
            bool estado = false;
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.productos.Add(productos);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;

        }
        public static bool Editar(Productos productos)
        {
            bool estado = false;

            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.Entry(productos).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }

        public static Productos Buscar(int Id)
        {
            Productos producto = new Productos();
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                producto = context.productos.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

            return producto;

        }

        public static bool Eliminar(int ProductoId)
        {
            Productos producto = null;
            bool estado = false;
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                producto = context.productos.Find(ProductoId);
                context.productos.Remove(producto);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }

        public static List<Productos> GetList(Expression<Func<Productos, bool>> criterioBusqueda)
        {
            List<Productos> producto = new List<Productos>();
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                producto = context.productos.Where(criterioBusqueda).ToList();
            }

            catch (Exception)
            {
                throw;
            }

            return producto;
        }

        public static List<Productos> GetProductoNombre(string nombre)
        {
            List<Productos> lista = new List<Productos>();
            SisAgroveterinariaDb context = new SisAgroveterinariaDb();
            lista = context.productos.Where(c => c.Nombre == nombre).ToList();
            return lista;
        }
        //busca esto nigga
        public static List<Productos> ListarTodo()
        {
            List<Productos> lista = null;
            SisAgroveterinariaDb context = new SisAgroveterinariaDb();

            lista = context.productos.ToList();


            return lista;
        }




    }

}

