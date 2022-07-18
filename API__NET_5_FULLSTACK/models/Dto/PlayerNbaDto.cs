using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API__NET_5_FULLSTACK.models.Dto
{
    public class PlayerNbaDto
    {
        public int Id { get; set; }

        public string nombre { get; set; }
        public string equipo { get; set; }

        public int numero { get; set; }
    }
}
