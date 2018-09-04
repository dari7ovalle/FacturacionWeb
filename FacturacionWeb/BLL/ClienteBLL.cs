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
    public class ClienteBLL
    {

       

        public static bool Guardar(Clientes cliente)
        {
            bool estado = false;
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.clientes.Add(cliente);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;

        }
        public static bool Editar(Clientes clientes)
        {
            bool estado = false;

            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.Entry(clientes).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }

        public static Clientes Buscar(int Id)
        {
            Clientes cliente = new Clientes();
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                cliente = context.clientes.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

            return cliente;

        }

        public static bool Eliminar(int clienteId)
        {
            Clientes cliente = null;
            bool estado = false;
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                cliente = context.clientes.Find(clienteId);
                context.clientes.Remove(cliente);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }

        public static List<Clientes> GetList(Expression<Func<Clientes, bool>> criterioBusqueda)
        {
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                clientes = context.clientes.Where(criterioBusqueda).ToList();
            }

            catch (Exception)
            {
                throw;
            }

            return clientes;
        }

        public static List<Clientes> GetClientesNombre(string nombre)
        {
            List<Clientes> lista = new List<Clientes>();
            SisAgroveterinariaDb context = new SisAgroveterinariaDb();
            lista = context.clientes.Where(c => c.Nombres == nombre).ToList();
            return lista;
        }
        //busca esto nigga
        public static List<Clientes> ListarTodo()
        {
            List<Clientes> lista = null;
            SisAgroveterinariaDb context = new SisAgroveterinariaDb();
            
                lista = context.clientes.ToList();
            

            return lista;
        }


    }

}
