using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BarberiaEntityFramework.Models
{
    public class FacturaDetail
    {
        //Samuel De Freitas
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Precio { get; set; }

        [Required]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Discount { get; set; }
    }
}
