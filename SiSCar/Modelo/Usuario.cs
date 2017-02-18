using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiSCar.Modelo
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int pkUsuario { get; set; }

        [Required(ErrorMessage = "Se requiere Email")]
        [StringLength(100)]
        public String sEmail { get; set; }

        [Required(ErrorMessage = "Password Obligatorio")]
        [StringLength(140)]
        public String sPassword { get; set; }

        public Boolean bStatus { get; set; }

        public Usuario()
        {
            this.bStatus = true;
        }

        public virtual Rol rol { get; set; }

    }
}
