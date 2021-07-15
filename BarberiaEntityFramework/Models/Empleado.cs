using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BarberiaEntityFramework.Models
{
    public class Empleado
    {
        //Samuel De Freitas
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(10)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(15)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(20)]
        public string NroTelefono { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime FechaInicio { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaFin { get; set; }

        [Required]
        [Column(TypeName = "decimal(7,2)")]
        public decimal Salario { get; set; }

        public ICollection<Factura> Facturas { get; set; }

        public ICollection<Inventario> Inventarios { get; set; }
    }
}
