using simulado.Models;

namespace simulado.Services.Profile;

public interface IProfileService
{
    Task<int> CreateProfile(User profile);
    Task<User?> GetUserByLogin(string username);
    Task<User?> GetUserByID(int ID);
}