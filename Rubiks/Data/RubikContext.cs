using Microsoft.EntityFrameworkCore;
using Rubiks.Models;

namespace Rubiks.Data
{
    public class RubikContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(@"server=localhost;database=Rubik;uid=root;password=pepe31;");
    }
        
    public DbSet<RubikCube> RubikCube { get; set; }
    public DbSet<TrackingSolution> TrackingSolution { get; set; }
}
}