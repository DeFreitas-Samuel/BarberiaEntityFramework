using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BarberiaEntityFramework.Models;

namespace BarberiaEntityFramework.Data
{
    public class BarberiaEntityFrameworkContext : DbContext
    {
        //Samuel De Freitas
        public BarberiaEntityFrameworkContext (DbContextOptions<BarberiaEntityFrameworkContext> options)
            : base(options)
        {
        }


        public DbSet<BarberiaEntityFramework.Models.Cliente> Cliente { get; set; }

        public DbSet<BarberiaEntityFramework.Models.Ciudad> Ciudad { get; set; }

        public DbSet<BarberiaEntityFramework.Models.Inventario> Inventario { get; set; }

        public DbSet<BarberiaEntityFramework.Models.Servicio> Servicio { get; set; }

        public DbSet<BarberiaEntityFramework.Models.TipoEmpleado> TipoEmpleado { get; set; }

        public DbSet<BarberiaEntityFramework.Models.TipoPago> TipoPago { get; set; }

        public DbSet<BarberiaEntityFramework.Models.Empleado> Empleado { get; set; }

        public DbSet<BarberiaEntityFramework.Models.Sucursal> Sucursal { get; set; }

        public DbSet<BarberiaEntityFramework.Models.Factura> Factura { get; set; }

        public DbSet<BarberiaEntityFramework.Models.FacturaDetail> FacturaDetail { get; set; }
    }
}
