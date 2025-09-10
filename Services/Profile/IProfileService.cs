using simulado.Models;

namespace simulado.Services.Profile;

public interface IProfileService
{
    Task<int> CreateProfile(User profile);
    Task<User?> GetProfile(string username);
}