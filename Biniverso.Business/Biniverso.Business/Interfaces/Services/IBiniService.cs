using Biniverso.Business.Models.Entities;

namespace Biniverso.Business.Interfaces.Services
{
    public interface IBiniService
    {
        Task Add(Bini bini);
        Task Update(Bini bini);
        Task<bool> Remove(int id);
    }
}
