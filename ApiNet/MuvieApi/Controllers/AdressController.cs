using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MuvieApi.Data;
using MuvieApi.Data.Dtos;
using MuvieApi.Models;
namespace MuvieApi.Controllers;

[ApiController]
    [Route("[controller]")]
    public class AddressController(MovieContext context, IMapper mapper) : ControllerBase
    {
        private MovieContext _context = context;
        private IMapper _mapper = mapper;

    [HttpPost]
        public IActionResult AdicionaEndereco([FromBody] CreateAddressDto addressDto)
        {
            Address address = _mapper.Map<Address>(addressDto);
            _context.Addresses.Add(address);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaEnderecosPorId), new { Id = address.Id }, addressDto);
        }

        [HttpGet]
        public IEnumerable<ReadAddressDto> RecuperaEnderecos()
        {
            return _mapper.Map<List<ReadAddressDto>>(_context.Addresses.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEnderecosPorId(int id)
        {
            Address address = _context.Addresses.FirstOrDefault(address => address.Id == id);
            if (address != null)
            {
                ReadAddressDto addressDto = _mapper.Map<ReadAddressDto>(address);
                return Ok(addressDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEndereco(int id, [FromBody] UpdateAddressDto addressDto)
        {
            Address address = _context.Addresses.FirstOrDefault(address => address.Id == id);
            if (address == null)
            {
                return NotFound();
            }
            _mapper.Map(addressDto, address);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaEndereco(int id)
        {
            Address address = _context.Addresses.FirstOrDefault(address => address.Id == id);
            if (address == null)
            {
                return NotFound();
            }
            _context.Remove(address);
            _context.SaveChanges();
            return NoContent();
        }

    }