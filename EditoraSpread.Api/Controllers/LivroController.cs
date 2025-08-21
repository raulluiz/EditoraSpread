using AutoMapper;
using EditoraSpread.Application.DTOs.Livro;
using EditoraSpread.Application.Services;
using EditoraSpread.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EditoraSpread.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LivroController(LivroService livroService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<LivroDto>>> GetAll()
    {
        var livros = await livroService.ObterTodosAsync();
        return Ok(mapper.Map<IEnumerable<LivroDto>>(livros));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<LivroDto>> GetById(int id)
    {
        var livro = await livroService.ObterPorIdAsync(id);
        if (livro == null) return NotFound();

        return Ok(mapper.Map<LivroDto>(livro));
    }

    [HttpPost]
    public async Task<ActionResult> Create(CreateLivroDto dto)
    {
        var livro = mapper.Map<Livro>(dto);
        await livroService.CriarAsync(livro);
        return CreatedAtAction(nameof(GetById), new { id = livro.Id }, mapper.Map<LivroDto>(livro));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, UpdateLivroDto dto)
    {
        var livro = await livroService.ObterPorIdAsync(id);
        if (livro == null) return NotFound();

        mapper.Map(dto, livro);
        await livroService.AtualizarAsync(livro);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var livro = await livroService.ObterPorIdAsync(id);
        if (livro == null) return NotFound();

        await livroService.RemoverAsync(id);
        return NoContent();
    }
}
