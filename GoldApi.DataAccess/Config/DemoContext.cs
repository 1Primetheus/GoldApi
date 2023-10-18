using Microsoft.EntityFrameworkCore;
using GoldApi.DataAccess.Entities;
using GoldApi.DataAccess.EntityConfigurations;
using GoldApi.DataAccess.Configurations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Design;

namespace GoldApi.DataAccess.Configurations;

public class DemoContext : DbContext
{
    public virtual DbSet<User> Users => Set<User>(); 

    public DemoContext(){}

    public DemoContext(DbContextOptions<DemoContext> options) : base(options)
    {
    }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(DbConstants.SchemaName);

        modelBuilder.ApplyConfiguration(new UserConfiguration());

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
       .UseNpgsql()
       .UseLowerCaseNamingConvention();

}

