using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MuvieApi.Data;
using MuvieApi.Data.Dtos;
using MuvieApi.Models;

namespace MuvieApi.Controllers;

[ApiController]
[Route("[Controller]")]
public class SectionController(MovieContext context, IMapper mapper) : ControllerBase
{
    private MovieContext _context = context;
    private IMapper _mapper = mapper;

    [HttpPost]
    public IActionResult AdicionaEndereco([FromBody] CreateSectionDto sectionDto)
    {
        Section section = _mapper.Map<Section>(sectionDto);
        _context.Sections.Add(section);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaEnderecosPorId), new { MovieId = section.MovieId, CinemaId = section.CinemaId }, sectionDto);
    }

    [HttpGet]
    public IEnumerable<ReadSectionDto> RecuperaEnderecos()
    {
        return _mapper.Map<List<ReadSectionDto>>(_context.Sections.ToList());
    }

    [HttpGet("{MovieId}/{CinemaId}")]
    public IActionResult RecuperaEnderecosPorId(int MovieId, int CinemaId)
    {
        Section? section = _context.Sections.FirstOrDefault(section => section.MovieId == MovieId && section.CinemaId == CinemaId);
        if (section != null)
        {
            ReadSectionDto sectionDto = _mapper.Map<ReadSectionDto>(section);
            return Ok(sectionDto);
        }
        return NotFound();
    }



    [HttpDelete("{MovieId}/{CinemaId}")]
    public IActionResult DeletaEndereco(int MovieId, int CinemaId)
    {
        Section? section = _context.Sections.FirstOrDefault(section => section.MovieId == MovieId && section.CinemaId == CinemaId);
        if (section == null)
        {
            return NotFound();
        }
        _context.Remove(section);
        _context.SaveChanges();
        return NoContent();
    }
}
