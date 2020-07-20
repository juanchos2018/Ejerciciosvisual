using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioLp2_u2.Entidad
{
    class ClsKardex:ClsProductos
    {
            public DateTime fecha { get; set; }

            public ClsTIpo tipo { get; set; }
            public int saldo_anterior { get; set; }
            public int entradas { get; set; }
            public int salidas { get; set; }
            public int saldo_actual { get; set; }

    }
}
