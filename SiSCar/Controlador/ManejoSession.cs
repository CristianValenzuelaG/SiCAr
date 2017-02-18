using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiSCar.Modelo;

namespace SiSCar.Controlador
{
    public class ManejoSession
    {
        public static SessionHelper Login(string User, string Password)
        {
            SessionHelper objSession = new SessionHelper();
            try
            {
                using (var ctx = new DataModel())
                {
                    Usuario user = ctx.usuarios.Include("rol").Include("rol.permisosnegadorol").Where(r => r.sEmail == User && r.bStatus == true).FirstOrDefault();
                    if (user != null)
                    {
                        if (user.sPassword == Password)
                        {
                            objSession.isVald = true;
                            objSession.usuario = user;
                        }
                    }
                }
                return objSession;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    public class SessionHelper
    {
        public Boolean isVald { get; set; }
        public Usuario usuario { get; set; }
        public String msgError { get; set; }

        public SessionHelper()
        {
            this.isVald = false;
            this.usuario = null;
            this.msgError = "Datos incorrecctos, Favor de Verificar";
        }
        public Boolean tienePermiso(int ValidarPermiso)
        {
            Boolean tiene = false;
            if (isVald)
            {
                try
                {
                    using (var ctx = new DataModel())
                    {
                        PermisoNegadoRol pNegado = usuario.rol.permisosnegadorol.Where(r => r.permiso.pkPermiso == ValidarPermiso).FirstOrDefault();
                        if (pNegado == null)
                            tiene = true;
                    }
                    return tiene;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                return tiene;
            }
        }
    }
    public enum enumPermisoActivos
    {
        Alumno_Nuevo = 1,
        Alumno_Buscar = 2,
        Alumno_Actualizar = 4,
        Alumno_Borrar = 3,
        //------------------
        Maestro_Nuevo = 8,
        Maestro_Buscar = 7,
        Maestro_Actualizar = 5,
        Maestro_Borrar = 6,
    }
}
