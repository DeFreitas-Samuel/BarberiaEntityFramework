// <auto-generated />
using System;
using BarberiaEntityFramework.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BarberiaEntityFramework.Migrations
{
    [DbContext(typeof(BarberiaEntityFrameworkContext))]
    [Migration("20210715181100_BugFixing")]
    partial class BugFixing
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BarberiaEntityFramework.Models.Ciudad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Ciudad");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("NroTelefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Empleado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("NroTelefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("TipoEmpleadoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TipoEmpleadoID");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Factura", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<int>("clienteID")
                        .HasColumnType("int");

                    b.Property<int>("empleadoID")
                        .HasColumnType("int");

                    b.Property<int>("sucursalID")
                        .HasColumnType("int");

                    b.Property<int>("tipoPagoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("clienteID");

                    b.HasIndex("empleadoID");

                    b.HasIndex("sucursalID");

                    b.HasIndex("tipoPagoID");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.FacturaDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int?>("FacturaID")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int?>("ServicioID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FacturaID");

                    b.HasIndex("ServicioID");

                    b.ToTable("FacturaDetail");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Inventario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("empleadoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("empleadoID");

                    b.ToTable("Inventario");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Servicio", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ID");

                    b.ToTable("Servicio");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Sucursal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("ciudadID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ciudadID");

                    b.ToTable("Sucursal");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.TipoEmpleado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("TipoEmpleado");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.TipoPago", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("TipoPago");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Empleado", b =>
                {
                    b.HasOne("BarberiaEntityFramework.Models.TipoEmpleado", null)
                        .WithMany("Empleados")
                        .HasForeignKey("TipoEmpleadoID");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Factura", b =>
                {
                    b.HasOne("BarberiaEntityFramework.Models.Cliente", "cliente")
                        .WithMany("Facturas")
                        .HasForeignKey("clienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BarberiaEntityFramework.Models.Empleado", "empleado")
                        .WithMany("Facturas")
                        .HasForeignKey("empleadoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BarberiaEntityFramework.Models.Sucursal", "sucursal")
                        .WithMany("Facturas")
                        .HasForeignKey("sucursalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BarberiaEntityFramework.Models.TipoPago", "tipoPago")
                        .WithMany("Facturas")
                        .HasForeignKey("tipoPagoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");

                    b.Navigation("empleado");

                    b.Navigation("sucursal");

                    b.Navigation("tipoPago");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.FacturaDetail", b =>
                {
                    b.HasOne("BarberiaEntityFramework.Models.Factura", null)
                        .WithMany("FacturaDetails")
                        .HasForeignKey("FacturaID");

                    b.HasOne("BarberiaEntityFramework.Models.Servicio", null)
                        .WithMany("FacturaDetails")
                        .HasForeignKey("ServicioID");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Inventario", b =>
                {
                    b.HasOne("BarberiaEntityFramework.Models.Empleado", "empleado")
                        .WithMany("Inventarios")
                        .HasForeignKey("empleadoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("empleado");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Sucursal", b =>
                {
                    b.HasOne("BarberiaEntityFramework.Models.Ciudad", "ciudad")
                        .WithMany("Sucursales")
                        .HasForeignKey("ciudadID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ciudad");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Ciudad", b =>
                {
                    b.Navigation("Sucursales");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Cliente", b =>
                {
                    b.Navigation("Facturas");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Empleado", b =>
                {
                    b.Navigation("Facturas");

                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Factura", b =>
                {
                    b.Navigation("FacturaDetails");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Servicio", b =>
                {
                    b.Navigation("FacturaDetails");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.Sucursal", b =>
                {
                    b.Navigation("Facturas");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.TipoEmpleado", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("BarberiaEntityFramework.Models.TipoPago", b =>
                {
                    b.Navigation("Facturas");
                });
#pragma warning restore 612, 618
        }
    }
}
