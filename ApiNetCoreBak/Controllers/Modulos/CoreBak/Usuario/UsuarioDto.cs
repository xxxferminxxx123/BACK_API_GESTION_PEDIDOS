namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Usuario
{
    public class UsuarioDto
    {
        public Guid UsuarioId { get; set; }
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
        public bool Estado { get; set; }
    }
}
