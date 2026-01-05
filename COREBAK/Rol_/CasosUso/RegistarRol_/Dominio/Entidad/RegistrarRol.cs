namespace COREBAK.Rol_.CasosUso.RegistrarRol_.Dominio.Entidad
{
    public class RegistrarRol
    {
        public Guid? RolId { get; set; }
        public string? Descripcion { get; set; }
        public string? Codigo { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }


        //public DateTime FechaModificacion { get; set; }
        //public string UsuarioModificacion { get; set; }
        //public DateTime FechaEliminacion { get; set; }
        //public string UsuarioEliminacion { get; set; }

        private RegistrarRol() { }

        public RegistrarRol(
            Guid rolId,
            string descripcion,
            string codigo,
            bool activo,
            DateTime fechaRegistro,
            string usuarioRegistro
            ////DateTime fechaModificacion,
            //string usuarioModificacion,
            //DateTime fechaEliminacion,
            //string usuarioEliminacion
            )
        {
            RolId = rolId;
            Descripcion = descripcion;
            Codigo = codigo;
            Activo = activo;
            FechaRegistro = fechaRegistro;
            UsuarioRegistro = usuarioRegistro;
            //FechaModificacion= fechaModificacion;
            //UsuarioModificacion = usuarioModificacion;
            //FechaEliminacion = fechaEliminacion;
            //UsuarioEliminacion = usuarioEliminacion;
        }
    }
}