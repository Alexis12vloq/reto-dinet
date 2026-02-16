using CrudSpApi.Data;
using CrudSpApi.Models;
using CrudSpApi.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CrudSpApi.Repositories;

public class PersonaRepository : IPersonaRepository
{
    private readonly ApplicationDbContext _context;

    public PersonaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Persona>> GetAllAsync()
    {
        return await _context.Personas
            .FromSqlRaw("CALL sp_GetPersonas()")
            .ToListAsync();
    }

    public async Task<Persona?> GetByIdAsync(int id)
    {
        var result = await _context.Personas
            .FromSqlRaw("CALL sp_GetPersonaById({0})", id)
            .ToListAsync();

        return result.FirstOrDefault();
    }

    public async Task CreateAsync(PersonaDto dto)
    {
        await _context.Database.ExecuteSqlRawAsync(
            "CALL sp_InsertPersona({0}, {1}, {2})",
            dto.Nombre,
            dto.Apellido,
            dto.Edad
        );
    }

    public async Task UpdateAsync(int id, PersonaDto dto)
    {
        await _context.Database.ExecuteSqlRawAsync(
            "CALL sp_UpdatePersona({0}, {1}, {2}, {3})",
            id,
            dto.Nombre,
            dto.Apellido,
            dto.Edad
        );
    }

    public async Task DeleteAsync(int id)
    {
        await _context.Database.ExecuteSqlRawAsync(
            "CALL sp_DeletePersona({0})", id);
    }
}