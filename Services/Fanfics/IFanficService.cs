using simulado.Models;

namespace simulado.Services.Fanfics;

public interface IFanficService
{
    Task<Fanfic> GetFanficByID(int ID);
    Task<int> CreateFanfic(Fanfic fanfic);
}