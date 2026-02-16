using Microsoft.EntityFrameworkCore;
using CrudSpApi.Models;

namespace CrudSpApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Persona> Personas => Set<Persona>();
}