using Fanfix.Services.JWT;
using simulado;
using simulado.Services.Profile;
using simulado.UseCases.User.Login;

public class LoginUseCase
(
    IProfileService profileService,
    IJWTService jWTService
)
{
    public async Task<Result<LoginResponse>>Do(LoginPayload payload)
    {
        var user = await profileService.GetProfile(payload.Login);

        if (user is null)
            return Result<LoginResponse>.Fail("User not found");

        if (payload.Password != user.Password)
            return Result<LoginResponse>.Fail("Wrong password");

        var jwt = jWTService.CreateToken(new(
            user.ID, user.Username
        ));

        return Result<LoginResponse>.Success(new LoginResponse(jwt));
    }
}