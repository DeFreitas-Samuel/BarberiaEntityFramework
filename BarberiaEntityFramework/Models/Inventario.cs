using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BarberiaEntityFramework.Models
{
    public class Inventario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(10)]
        public string Nombre { get; set; }

        [Required]
        public int Cantidad { get; set; }

    }
}
