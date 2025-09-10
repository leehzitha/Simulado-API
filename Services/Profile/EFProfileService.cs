using simulado.Models;
using Microsoft.EntityFrameworkCore;


namespace simulado.Services.Profile;

public class ProfileService(SimuladoDbContext ctx) : IProfileService
{
    public async Task<int> CreateProfile(User user)
    {
        ctx.Users.Add(user);
        await ctx.SaveChangesAsync();
        return user.ID;
    }

    public async Task<User?> GetUserByLogin(string login)
    {
        return await ctx.Users.FirstOrDefaultAsync(
            p => p.Username == login || p.Email == login
        );
    }

    public async Task<User?> GetUserByID(int ID)
    {
        return await ctx.Users.FirstOrDefaultAsync(
            u => u.ID == ID
        );
    }
}