using Biniverso.Business.Interfaces.Repository;
using Biniverso.Business.Interfaces.Services;
using Biniverso.Business.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biniverso.Business.Services
{
    public class BiniService : IBiniService
    {
        private readonly IBiniRepository _biniRepository;

        public BiniService(IBiniRepository biniRepository)
        {
            _biniRepository = biniRepository;
        }
        public async Task Add(Bini bini)
        {
           bini.Date = DateTime.Now;

           await _biniRepository.AddBini(bini);
        }

        public async Task Update(Bini bini)
        {
            await _biniRepository.UpdateBini(bini);
        }

        public async Task<bool> Remove(int id)
        {
            await _biniRepository.RemoveBini(id);

            return true;
        }        
    }
}
