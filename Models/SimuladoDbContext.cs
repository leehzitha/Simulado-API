using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using simulado.Models;

namespace simulado.Models;

public class SimuladoDbContext(DbContextOptions<SimuladoDbContext> opts) : DbContext(opts)
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Fanfic> Fanfics => Set<Fanfic>();
    public DbSet<ReadList> ReadLists => Set<ReadList>();

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<User>()
        .HasMany(u => u.FanficsCreated)
        .WithOne(f => f.Creator)
        .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<Fanfic>()
        .HasOne(f => f.Creator)
        .WithMany(u => u.FanficsCreated)
        .HasForeignKey(f => f.CreatorID)
        .OnDelete(DeleteBehavior.NoAction);

        mb.Entity<ReadList>()
        .HasMany(r => r.Fanfics)
        .WithMany(f => f.ReadLists)

        .UsingEntity(j => j.ToTable("ReadListFanfics"));
    }
}

public class RPlaceDbContextFactory : IDesignTimeDbContextFactory<SimuladoDbContext>
{
    public SimuladoDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<SimuladoDbContext>();
        var sqlConn = Environment.GetEnvironmentVariable("SQL_CONNECTION");
        options.UseSqlServer(sqlConn);
        return new SimuladoDbContext(options.Options);
    }
}