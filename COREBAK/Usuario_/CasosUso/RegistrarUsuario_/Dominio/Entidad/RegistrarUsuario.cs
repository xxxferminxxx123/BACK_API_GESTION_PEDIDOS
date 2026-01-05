using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.ValueObjects;

namespace COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.Entidad
{
    public class RegistrarUsuario
    {
        public Guid IdUsuario { get; set; }
        public UsuarioVO Usuario { get; set; }
        public Guid IdPersona { get; set; }
        public Boolean Activo { get; set; }
        public DateTime FechaRegistro { get; set; }

        private RegistrarUsuario() { }

        public RegistrarUsuario(
            Guid idUsuario,
            UsuarioVO usuario,
            Guid idPersona,
            bool activo,
            DateTime fechaRegistro)
        {
            IdUsuario = idUsuario;
            Usuario = usuario;
            IdPersona = idPersona;
            Activo = activo;
            FechaRegistro = fechaRegistro;
        }
    }
}