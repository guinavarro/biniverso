using Biniverso.Business.Models.Entities;

namespace Biniverso.Business.Interfaces
{
    public interface IBiniRepository
    {
        Task<Bini> AddBini(Bini bini);
        Task<Bini> UpdateBini(Bini bini);
        Task<Bini> GetBiniByid(int id);
        Task<List<Bini>> GetAllBinies();
        Task<bool> RemoveBini(int id);
    }
}
