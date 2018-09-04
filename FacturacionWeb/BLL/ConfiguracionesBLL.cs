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
   public  class ConfiguracionesBLL
    {


        public static bool Guardar(Configuraciones configuraciones)
        {
            bool estado = false;
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.configuraciones.Add(configuraciones);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;

        }
        public static bool Editar(Configuraciones configuraciones)
        {
            bool estado = false;

            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.Entry(configuraciones).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }

        public static Configuraciones Buscar(int Id)
        {
            Configuraciones conf = new Configuraciones();
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                conf = context.configuraciones.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

            return conf;

        }

        public static List<Configuraciones> GetList(Expression<Func<Configuraciones, bool>> criterioBusqueda)
        {
            List<Configuraciones> configuraciones = new List<Configuraciones>();
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                configuraciones = context.configuraciones.Where(criterioBusqueda).ToList();
            }

            catch (Exception)
            {
                throw;
            }

            return configuraciones;
        }
    }
}
