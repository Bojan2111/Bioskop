using AutoMapper;
using AutoMapper.QueryableExtensions;
using Bioskop.Interfaces;
using Bioskop.Models;
using Bioskop.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Bioskop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjekcijeController : ControllerBase
    {
        private readonly IProjekcijaRepository _projekcijaRepository;
        private readonly IMapper _mapper;

        public ProjekcijeController(IProjekcijaRepository projekcijaRepository, IMapper mapper)
        {
            _projekcijaRepository = projekcijaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/api/projekcije")]
        public IActionResult GetFirstEntities()
        {
            return Ok(_projekcijaRepository.GetAll().ProjectTo<ProjekcijaDTO>(_mapper.ConfigurationProvider).ToList());
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("/api/projekcije/{id}")]
        public IActionResult GetProjekcija(int id)
        {
            var mesto = _projekcijaRepository.GetById(id);
            if (mesto == null)
            {
                return NotFound();
            }
            return Ok(mesto);
        }

        //[Authorize]
        [HttpPost]
        [Route("/api/projekcije")]
        public IActionResult PostProjekcija(Projekcija projekcija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _projekcijaRepository.Add(projekcija);
            return CreatedAtAction("GetProjekcija", new { id = projekcija.Id }, projekcija);
        }

        //[Authorize]
        [HttpPut("/api/projekcije/{id}")]
        public IActionResult PutProjekcija(int id, Projekcija projekcija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != projekcija.Id)
            {
                return BadRequest();
            }

            try
            {
                _projekcijaRepository.Update(projekcija);
            }
            catch
            {
                return BadRequest();
            }

            return Ok(projekcija);
        }

        //[Authorize]
        [HttpDelete("/api/projekcije/{id}")]
        public IActionResult DeleteProjekcija(int id)
        {
            var projekcija = _projekcijaRepository.GetById(id);
            if (projekcija == null)
            {
                return NotFound();
            }

            _projekcijaRepository.Delete(projekcija);
            return NoContent();
        }
    }
}
