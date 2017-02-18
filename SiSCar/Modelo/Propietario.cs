using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiSCar.Modelo
{
    class Propietario
    {
        public int pkPropietario { get; set; }
        public string pNombre { get; set; }
        public string pDireccion{ get; set; }
        public string pTelefono { get; set; }
        public string pCorreo { get; set; }
        public string pIfe { get; set; }
       // public Bitmap pFoto { get; set; }
       public Boolean pStatus { get; set; }


    }
}
