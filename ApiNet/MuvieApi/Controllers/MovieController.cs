using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MuvieApi.Data;
using MuvieApi.Data.Dtos;
using MuvieApi.Models;

namespace MuvieApi.Controllers;

[ApiController]
[Route("[Controller]")]
public class MovieController(MovieContext context, IMapper mapper) : ControllerBase
{
    private readonly MovieContext _context = context;
    private readonly IMapper _mapper = mapper;

    [HttpPost]
    public async Task<IActionResult> AddMovie([FromBody] CreateMovieDto createMovieDto)
    {
        var movie = _mapper.Map<Movie>(createMovieDto);

        await _context.Movies.AddAsync(movie);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie);
    }

    [HttpPost("batch")]
    public async Task<IActionResult> AddMovies([FromBody] IEnumerable<CreateMovieDto> createMovieDtos)
    {
        var movieList = createMovieDtos.Select(_mapper.Map<Movie>).ToList();
        if (!movieList.Any()) return BadRequest("Movie list cannot be empty.");

        await _context.Movies.AddRangeAsync(movieList);
        await _context.SaveChangesAsync();

        return Ok(movieList);
    }

    [HttpGet]
    public async Task<IEnumerable<ReadMovieDto>> GetMovies([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadMovieDto>>(await _context.Movies
        .OrderBy(movie => movie.Id)
        .Skip(skip)
        .Take(take)
        .ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetMovie(int id)
    {
        var movie = await _context.Movies.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);
        if (movie == null) return NotFound();

        var movieDto = _mapper.Map<ReadMovieDto>(movie);

        return Ok(movie);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateMovie(int id, [FromBody] UpdateMovieDto movieDto)
    {
        var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);

        if (movie == null) return NotFound();

        _mapper.Map(movieDto, movie);

        await _context.SaveChangesAsync();

        return Ok(movie);
    }


    [HttpPatch("{id}")]
    public IActionResult UpdateMoviePatch(int id,
      JsonPatchDocument<UpdateMovieDto>? movieDtoPath)
    {
        if (movieDtoPath == null)
        {
            return BadRequest("O corpo da requisição deve ser um documento JSON Patch válido.");
        }

        var movie = _context.Movies.FirstOrDefault(m => m.Id == id);

        if (movie == null) return NotFound();

        var updateMovieDto = _mapper.Map<UpdateMovieDto>(movie);

        movieDtoPath.ApplyTo(updateMovieDto, ModelState);

        if (!TryValidateModel(updateMovieDto))
        {
            return ValidationProblem(ModelState);
        }

        _mapper.Map(updateMovieDto, movie);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMovie(int id)
    {
        var existingMovie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
        if (existingMovie == null)
        {
            return NotFound();
        }

        _context.Movies.Remove(existingMovie);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}


/*
PELOAD 
[
  {
    "op": "replace",
    "path": "/gender",
    "value": "TESTE........................."
  },
  {
    "op": "replace",
    "path": "/director",
    "value": "TESTE.................."
  },
  {
    "op": "replace",
    "path": "/duration",
    "value": 20
  }
]
*/