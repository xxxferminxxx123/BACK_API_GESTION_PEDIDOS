namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Rol.CasosUso.RegistrarRol.DTO
{
    public class RegistrarRolBodyDTO
    {
        public Guid? RolId { get; set; }
        public string? Descripcion { get; set; }
        public string? Codigo { get; set; }
        public bool? Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public string UsuarioEliminacion { get; set; }
    }
}
