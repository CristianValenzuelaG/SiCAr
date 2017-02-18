using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiSCar.Modelo
{
    class Venta
    {
        public int pkVenta { get; set; }
        public int fkComprador { get; set; }
        public int fkAuto { get; set; }
        public DateTime vFecha { get; set; }
        public int vTotal { get; set; }

    }
}
