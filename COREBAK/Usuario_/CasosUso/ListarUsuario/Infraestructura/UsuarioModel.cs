using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COREBAK.Usuario_.CasosUso.ListarUsuario.Infraestructura
{
    public class UsuarioModel
    {
        public Guid IdUsuario { get; set; }
        public string Usuario { get; set; }
        public Guid IdPersona { get; set; }
        public Boolean Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
