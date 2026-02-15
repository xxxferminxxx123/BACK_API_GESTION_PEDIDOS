using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.ValueObjects;

namespace COREBAK.Usuario_.CasosUso.ListarUsuario.Dominio.Entidad
{
    public class EListarUsuario
    {
        public Guid IdUsuario { get; set; }
        public string Usuario { get; set; }
        public Guid IdPersona { get; set; }
        public Boolean Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        private EListarUsuario() { }

        public EListarUsuario(
            Guid idUsuario,
            string usuario,
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
