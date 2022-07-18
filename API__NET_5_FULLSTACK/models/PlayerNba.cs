using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API__NET_5_FULLSTACK.models
{
    public class PlayerNba
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string nombre { get; set; }
        [Required]
        public string equipo { get; set; }

        [Required]
        public int numero { get; set; }
    }
}
