using simulado.Models;
using Microsoft.EntityFrameworkCore;
using dtaplace.Models;

namespace simulado.Services.Profile;

public class ProfileService(SimuladoDbContext ctx) : IProfileService
{
    public async Task<int> CreateProfile(User user)
    {
        ctx.Users.Add(user);
        await ctx.SaveChangesAsync();
        return user.ID;
    }

    public async Task<User?> GetProfile(string login)
    {
        return await ctx.Users.FirstOrDefaultAsync(
            p => p.Username == login || p.Email == login
        );
    }
}