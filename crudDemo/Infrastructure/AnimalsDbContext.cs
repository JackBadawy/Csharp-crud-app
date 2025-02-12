using Microsoft.EntityFrameworkCore;

public class AnimalsDbContext : DbContext
{
    public AnimalsDbContext (DbContextOptions<AnimalsDbContext> options) : base(options) {}
    public DbSet<Animal> Animals {get; set;}
}
