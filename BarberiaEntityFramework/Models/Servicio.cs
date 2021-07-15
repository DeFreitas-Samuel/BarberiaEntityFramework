using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BarberiaEntityFramework.Models
{
    public class Servicio
    {
        //Samuel De Freitas
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Precio { get; set; }

        public ICollection<FacturaDetail> FacturaDetails { get; set; }

    }
}
