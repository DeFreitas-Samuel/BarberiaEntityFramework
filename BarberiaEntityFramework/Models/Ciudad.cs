using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BarberiaEntityFramework.Models
{
    public class Ciudad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(20)]
        public string Nombre { get; set; }

        public ICollection<Sucursal> Sucursales { get; set; }
    }
}
