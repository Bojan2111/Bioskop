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
    public class KarteController : ControllerBase
    {
        private readonly IKartaRepository _kartaRepository;
        private readonly IMapper _mapper;

        public KarteController(IKartaRepository kartaRepository, IMapper mapper)
        {
            _kartaRepository = kartaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/api/karte")]
        public IActionResult GetFirstEntities()
        {
            return Ok(_kartaRepository.GetAll().ProjectTo<KartaDTO>(_mapper.ConfigurationProvider).ToList());
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("/api/karte/{id}")]
        public IActionResult GetKarta(int id)
        {
            var mesto = _kartaRepository.GetById(id);
            if (mesto == null)
            {
                return NotFound();
            }
            return Ok(mesto);
        }

        //[Authorize]
        [HttpPost]
        [Route("/api/karte")]
        public IActionResult PostKarta(Karta karta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _kartaRepository.Add(karta);
            return CreatedAtAction("GetKarta", new { id = karta.Id }, karta);
        }

        //[Authorize]
        [HttpPut("/api/karte/{id}")]
        public IActionResult PutKarta(int id, Karta karta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != karta.Id)
            {
                return BadRequest();
            }

            try
            {
                _kartaRepository.Update(karta);
            }
            catch
            {
                return BadRequest();
            }

            return Ok(karta);
        }

        //[Authorize]
        [HttpDelete("/api/karte/{id}")]
        public IActionResult DeleteKarta(int id)
        {
            var karta = _kartaRepository.GetById(id);
            if (karta == null)
            {
                return NotFound();
            }

            _kartaRepository.Delete(karta);
            return NoContent();
        }
    }
}
