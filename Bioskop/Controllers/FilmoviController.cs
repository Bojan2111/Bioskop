using AutoMapper;
using Bioskop.Interfaces;
using Bioskop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bioskop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmoviController : ControllerBase
    {
        private readonly IFilmRepository _filmRepository;
        private readonly IMapper _mapper;

        public FilmoviController(IFilmRepository filmRepository, IMapper mapper)
        {
            _filmRepository = filmRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/api/filmovi")]
        public IActionResult GetFirstEntities()
        {
            return Ok(_filmRepository.GetAll());//.ProjectTo<FilmDTO>(_mapper.ConfigurationProvider).ToList());
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("/api/filmovi/{id}")]
        public IActionResult GetFilm(int id)
        {
            var mesto = _filmRepository.GetById(id);
            if (mesto == null)
            {
                return NotFound();
            }
            return Ok(mesto);
        }

        //[Authorize]
        [HttpPost]
        [Route("/api/filmovi")]
        public IActionResult PostFilm(Film film)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _filmRepository.Add(film);
            return CreatedAtAction("GetFilm", new { id = film.Id }, film);
        }

        //[Authorize]
        [HttpPut("/api/filmovi/{id}")]
        public IActionResult PutFilm(int id, Film film)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != film.Id)
            {
                return BadRequest();
            }

            try
            {
                _filmRepository.Update(film);
            }
            catch
            {
                return BadRequest();
            }

            return Ok(film);
        }

        //[Authorize]
        [HttpDelete("/api/filmovi/{id}")]
        public IActionResult DeleteFilm(int id)
        {
            var film = _filmRepository.GetById(id);
            if (film == null)
            {
                return NotFound();
            }

            _filmRepository.Delete(film);
            return NoContent();
        }
    }
}
