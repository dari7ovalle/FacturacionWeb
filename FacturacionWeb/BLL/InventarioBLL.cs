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
   public class InventarioBLL
    {

        public static bool Guardar(Inventario inventarios)
        {
            bool estado = false;
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.inventario.Add(inventarios);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;

        }
        public static bool Editar(Inventario inventario)
        {
            bool estado = false;

            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.Entry(inventario).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }
        public static Inventario Buscar(int Id)
        {
            Inventario inventarios = new Inventario();
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                inventarios = context.inventario.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

            return inventarios;

        }

        public static bool Eliminar(int InventarioId)
        {
            Inventario inventarios = null;
            bool estado = false;
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                inventarios = context.inventario.Find(InventarioId);
                context.inventario.Remove(inventarios);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }

        public static List<Inventario> GetList(Expression<Func<Inventario, bool>> criterioBusqueda)
        {
            List<Inventario> inventarios = new List<Inventario>();
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                inventarios = context.inventario.Where(criterioBusqueda).ToList();
            }

            catch (Exception)
            {
                throw;
            }

            return inventarios;
        }

        public static List<Inventario> GetInventarioNombre(string nombre)
        {
            List<Inventario> lista = new List<Inventario>();
            SisAgroveterinariaDb context = new SisAgroveterinariaDb();
            lista = context.inventario.Where(c => c.Nombre == nombre).ToList();
            return lista;
        }
        //busca esto nigga
        public static List<Inventario> ListarTodo()
        {
            List<Inventario> lista = null;
            SisAgroveterinariaDb context = new SisAgroveterinariaDb();

            lista = context.inventario.ToList();


            return lista;
        }



    }
}

