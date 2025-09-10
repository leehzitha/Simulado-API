namespace simulado.Services.JWT;

public interface IJWTService
{
    string CreateToken(ProfileAuth data);
}