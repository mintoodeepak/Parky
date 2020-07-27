using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ParkyAPI.Repository.IRepository;

namespace ParkyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationlParksController : Controller
    {
        private INationalParkRepository _npRepo;
        private readonly IMapper _mapper;
        public NationlParksController(INationalParkRepository nprepo, IMapper mapper)
        {
            _npRepo = nprepo;
            _mapper = mapper;
        }
        public IActionResult GetNationalParks()
        {
            var objList = _npRepo.GetNationalParks();
            return Ok(objList);
        }
    }
}
