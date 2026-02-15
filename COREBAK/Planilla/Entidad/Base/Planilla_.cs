namespace COREBAK.Planilla.Entidad.Base
{
    public class Planilla_
    {
        public Guid PlanillaId { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaConfiguracion { get; set; }
        public Guid SupervisorId { get; set; }
        public Guid FundoId { get; set; }
        public Guid CultivoId { get; set; }
        public Guid AreadId { get; set; }
        public Guid GrupoId { get; set; }
        public string Estado { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Planilla_(
             Guid planillaId
            , string codigo
            , DateTime fechaConfiguracion
            , Guid supervisorId
            , Guid fundoId
            , Guid cultivoId
            , Guid areadId
            , Guid grupoId
            , string estado
            , string usuarioRegistro
            , DateTime fechaRegistro
            )
        {
            PlanillaId = planillaId;
            Codigo = codigo;
            FechaConfiguracion = fechaConfiguracion;
            SupervisorId = supervisorId;
            FundoId = fundoId;
            CultivoId = cultivoId;
            AreadId = areadId;
            GrupoId = grupoId;
            Estado = estado;
            UsuarioRegistro = usuarioRegistro;
            FechaRegistro = fechaRegistro;
        }
    }
}