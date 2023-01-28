using AutoMapper;
using Biniverso.Business.Interfaces.Repository;
using Biniverso.Business.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Biniverso.Presentation.Controllers
{
    public class BiniController : Controller
    {
        private readonly IBiniRepository _biniRepository;
        private readonly IBiniService _biniService;
        private readonly IMapper _mapper;

        public BiniController(IBiniRepository biniRepository, 
                              IBiniService biniService,
                              IMapper mapper)
        {
            _mapper = mapper;
            _biniService = biniService;
            _biniRepository = biniRepository;
        }

    }
}