namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Usuario.CasosUso.RegistrarUsuario.RegistrarUsuarioDto
{
    public record RegistrarUsuarioBodyDTO
    {
        public string Usuario { get; set; }
        public bool Activo { get; set; }

    }
}
