using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SiSCar.Modelo
{
    class Auto
    {
        public int pkAuto { get; set; }
        public string aMarca { get; set; }
        public string aModelo { get; set; }
        public  int aAño { get; set; }
        public int aNSerie { get; set; }
        public string aNPlaca { get; set; }
        public string aColor { get; set; }
        public string aNacionalidad { get; set; }
        public string aComentario { get; set; }
        public decimal aPrecio { get; set; }
        // public blob aFoto1 { get; set; }
        // public blob aFoto2 { get; set; }
        // public blob aFoto3 { get; set; }
        public Boolean aStatus { get; set; }

    }
}
