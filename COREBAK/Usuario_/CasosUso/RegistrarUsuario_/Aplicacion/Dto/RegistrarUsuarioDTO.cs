using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.ValueObjects;

namespace COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Aplicacion.Dto
{
    public record RegistrarUsuarioDTO
    {
        public string Usuario { get; set; }
        public Boolean Activo { get; set; }
    }
}