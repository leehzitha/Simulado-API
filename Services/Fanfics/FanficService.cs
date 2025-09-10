using System.IdentityModel.Tokens.Jwt;
using simulado.Models;
using Microsoft.EntityFrameworkCore;


namespace simulado.Services.Fanfics;

public class FanficService(SimuladoDbContext ctx) : IFanficService
{
    public async Task<int> CreateFanfic(Fanfic fanfic)
    {
        ctx.Fanfics.Add(fanfic);
        await ctx.SaveChangesAsync();
        return fanfic.ID;

    }
    public async Task<Fanfic> GetFanficByID(int ID)
    {
        return await ctx.Fanfics.FirstOrDefaultAsync(
            f => f.ID == ID
        );
    }
}