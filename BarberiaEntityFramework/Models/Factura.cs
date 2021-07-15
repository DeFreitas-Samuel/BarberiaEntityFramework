using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BarberiaEntityFramework.Models
{
    public class Factura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }



        [Required]
        public Empleado empleado { get; set; }
        
        [Required]
        public Cliente cliente { get; set; }

        [Required]
        public TipoPago tipoPago { get; set; }

        [Required]
        public Sucursal sucursal { get; set; }

        public ICollection<FacturaDetail> FacturaDetails { get; set; }
    }
}
