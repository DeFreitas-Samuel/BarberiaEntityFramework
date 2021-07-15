using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BarberiaEntityFramework.Models
{
    public class Sucursal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public Ciudad ciudad { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        public string Calle { get; set; }

        public ICollection<Factura> Facturas { get; set; }

    }
}
