using Biniverso.Business.Interfaces.Repository;
using Biniverso.Business.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Biniverso.Data.Repository
{
    public class BiniRepository : IBiniRepository
    {
        private readonly BiniContext _context;

        public BiniRepository(BiniContext context)
        {
            _context = context;
        }
        public async Task<Bini> AddBini(Bini bini)
        {
            _context.Binies.Add(bini);
            _context.SaveChanges();

            return bini;
        }

        public async Task<bool> RemoveBini(int id)
        {
            Bini bini = await GetBiniByid(id);

            if(bini == null) throw new Exception("Houve um erro na hora de remover essa imagem!");

            _context.Binies.Remove(bini);
            _context.SaveChanges();

            return true;
        }

        public async Task<List<Bini>> GetAllBinies()
        {
            return await _context.Binies.AsNoTracking().ToListAsync();
        }

        public async Task<Bini> GetBiniByid(int id)
        {
            return _context.Binies.FirstOrDefault(b => b.Id == id);
        }

        public async  Task<Bini> UpdateBini(Bini updatedBini)
        {
           if(updatedBini == null) throw new Exception("Houve um erro na hora de atualizar essa imagem!");

           Bini bini = await GetBiniByid(updatedBini.Id);

            bini.Path = updatedBini.Path;
            bini.Title = updatedBini.Title;
            bini.Description = updatedBini.Description;

            _context.Binies.Update(bini);
            _context.SaveChanges();

            return bini;
        }
    }
}
