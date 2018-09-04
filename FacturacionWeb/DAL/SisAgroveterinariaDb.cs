using SisAgroVeterinaria.Entidades;
using System.Data.Entity;

namespace SisAgroVeterinaria.DAL
{
    public   class SisAgroveterinariaDb : DbContext
    {

        
        public DbSet<Ciudades> ciudades { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Configuraciones> configuraciones { get; set; }
        public DbSet<Inventario> inventario { get; set; }
        public DbSet<Productos> productos { get; set; }
        public DbSet<TipoProductos> tipoProductos { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<VentaDetalles> ventaDetalles { get; set; }
        public DbSet<Ventas> ventas { get; set; }


      public SisAgroveterinariaDb() : base("ConStr")
        {

        }
    }
}
