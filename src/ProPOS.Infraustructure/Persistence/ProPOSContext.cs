using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace ProPOS.Infraustructure.Persistence;

public class ProPOSContext(DbContextOptions<ProPOSContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProPOSContext).Assembly);
    }
}