using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioLp2_u2.Entidad
{
    class ClsMetadata
    {
        public string nombre { get; set; }
        public string tipo { get; set; }
        public long size { get; set; }
        public string ubicacion { get; set; }
        public DateTime creacion { get; set; }
        public DateTime modificacion { get; set; }
        public DateTime leido { get; set; }


    }
}
