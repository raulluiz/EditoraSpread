using AutoMapper;
using EditoraSpread.Application.DTOs.Autor;
using EditoraSpread.Application.Services;
using EditoraSpread.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EditoraSpread.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AutorController(
    AutorService autorService,
    IMapper mapper) : ControllerBase
{
    private readonly AutorService _autorService = autorService;
    private readonly IMapper _mapper = mapper;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AutorDto>>> GetAll()
    {
        var autores = await _autorService.ObterTodosAsync();
        var result = _mapper.Map<IEnumerable<AutorDto>>(autores);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AutorDto>> GetById(int id)
    {
        var autor = await _autorService.ObterPorIdAsync(id);
        if (autor == null) return NotFound();

        var result = _mapper.Map<AutorDto>(autor);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AutorCreateDto dto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var autor = _mapper.Map<Autor>(dto);
        await _autorService.CriarAsync(autor);

        var result = _mapper.Map<AutorDto>(autor);
        return CreatedAtAction(nameof(GetById), new { id = autor.Id }, result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] AutorUpdateDto dto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        if (id != dto.Id) return BadRequest("Id do autor inválido");

        var autor = _mapper.Map<Autor>(dto);
        await _autorService.AtualizarAsync(autor);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _autorService.RemoverAsync(id);
        return NoContent();
    }

    [HttpGet("buscar/{nome}")]
    public async Task<IActionResult> BuscarPorNome(string nome)
    {
        var autores = await _autorService.BuscarPorNomeAsync(nome);
        var result = _mapper.Map<IEnumerable<AutorDto>>(autores);
        return Ok(result);
    }
}