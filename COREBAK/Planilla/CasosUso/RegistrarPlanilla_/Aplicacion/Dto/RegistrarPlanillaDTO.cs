namespace COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Aplicacion.Dto
{
    public class RegistrarPlanillaDTO
    {
        public string Codigo { get; set; }
        public DateTime FechaConfiguracion { get; set; }
        public Guid SupervisorId { get; set; }
        public Guid FundoId { get; set; }
        public Guid CultivoID { get; set; }
        public Guid AreadId { get; set; }
        public Guid GrupoId { get; set; }
        public string Estado { get; set; }
    }
}
