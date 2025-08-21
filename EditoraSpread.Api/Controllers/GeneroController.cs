using AutoMapper;
using EditoraSpread.Application.DTOs.Genero;
using EditoraSpread.Application.Services;
using EditoraSpread.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EditoraSpread.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GeneroController(GeneroService generoService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<GeneroDto>>> GetAll()
    {
        var generos = await generoService.ObterTodosAsync();
        return Ok(mapper.Map<IEnumerable<GeneroDto>>(generos));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GeneroDto>> GetById(int id)
    {
        var genero = await generoService.ObterPorIdAsync(id);
        if (genero == null) return NotFound();

        return Ok(mapper.Map<GeneroDto>(genero));
    }

    [HttpPost]
    public async Task<ActionResult> Create(CreateGeneroDto dto)
    {
        var genero = mapper.Map<Genero>(dto);
        await generoService.CriarAsync(genero);
        return CreatedAtAction(nameof(GetById), new { id = genero.Id }, mapper.Map<GeneroDto>(genero));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, UpdateGeneroDto dto)
    {
        var genero = await generoService.ObterPorIdAsync(id);
        if (genero == null) return NotFound();

        mapper.Map(dto, genero);
        await generoService.AtualizarAsync(genero);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var genero = await generoService.ObterPorIdAsync(id);
        if (genero == null) return NotFound();

        await generoService.RemoverAsync(id);
        return NoContent();
    }
}
