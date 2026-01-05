namespace ApiNetCoreBak.Controllers.Modulos.JWT.IJwtTokenService_
{
    public interface IJwtTokenService
    {
        string GenerateToken(string userId, string email, List<string>? roles = null);
    }
}
