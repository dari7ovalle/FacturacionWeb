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
    public class UsuariosBLL
    {

            public static bool Guardar(Usuarios usuario)
            {
                bool estado = false;
                try
                {
                    SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                    context.usuarios.Add(usuario);
                    context.SaveChanges();
                    estado = true;

                }
                catch (Exception)
                {

                    throw;
                }
                return estado;

            }
        public static bool Editar(Usuarios usuarios)
        {
            bool estado = false;

            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.Entry(usuarios).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }

        public static Usuarios Buscar(int Id)
            {
            Usuarios usuario = new Usuarios();
                try
                {
                    SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                usuario = context.usuarios.Find(Id);
                }
                catch (Exception)
                {
                    throw;
                }

                return usuario;

            }

        public static bool Login(string nombre, string contrasena)
        {
            bool retorno = false;
            SisAgroveterinariaDb context = new SisAgroveterinariaDb();
            Usuarios usuarios = new Usuarios();
            usuarios = context.usuarios.FirstOrDefault(u => u.Nombres.Equals(nombre) && u.Contracena.Equals(contrasena));
            if (usuarios != null)
            {
                retorno = true;
            }
            return retorno;
        }

            public static bool Eliminar(int UsuarioId)
            {
            Usuarios usuario = null;
                bool estado = false;
                try
                {
                    SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                usuario = context.usuarios.Find(UsuarioId);
                    context.usuarios.Remove(usuario);
                    context.SaveChanges();

                    estado = true;

                }
                catch (Exception)
                {
                    throw;

                }
                return estado;
            }

            public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> criterioBusqueda)
            {
                List<Usuarios> usuario = new List<Usuarios>();
                try
                {
                    SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                usuario = context.usuarios.Where(criterioBusqueda).ToList();
                }

                catch (Exception)
                {
                    throw;
                }

                return usuario;
            }

        public static List<Usuarios> GetUsuariosNombre(string nombre)
        {
            List<Usuarios> lista = new List<Usuarios>();
            SisAgroveterinariaDb context = new SisAgroveterinariaDb();
            lista = context.usuarios.Where(c => c.Nombres == nombre).ToList();
            return lista;
        }
        //busca esto nigga
        public static List<Usuarios> ListarTodo()
        {
            List<Usuarios> lista = null;
            SisAgroveterinariaDb context = new SisAgroveterinariaDb();

            lista = context.usuarios.ToList();


            return lista;
        }




    }
}

