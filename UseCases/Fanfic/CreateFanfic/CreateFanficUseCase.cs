using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Http.HttpResults;
using simulado.Models;
using simulado.Services.Fanfics;
using simulado.Services.Profile;

namespace simulado.UseCases.Fanfics.CreateFanfic;

public class CreateFanficUseCase(
    IFanficService fanficService,
    IProfileService profileService
)
{
    public async Task<Result<CreateFanficResponse>> Do(CreateFanficPayload payload)
    {
        var creator = await profileService.GetUserByID(payload.CreatorID);

        if (creator is null)
        {
            return Result<CreateFanficResponse>.Fail("Invalid creator");
        }

        var fanfic = new Fanfic
        {
            Title = payload.Title,
            CreatorID = payload.CreatorID,
            Creator = creator
        };

        await fanficService.CreateFanfic(fanfic);
        return Result<CreateFanficResponse>.Success(new());

    }
}