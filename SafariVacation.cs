using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
using AnimalModel;

namespace SafariVacation
{
  public partial class SafariVacation : DbContext
  {

    public DbSet<AnimalModel.animal> Animals { get; set; }

    public SafariVacation()
    {
    }

    public SafariVacation(DbContextOptions<SafariVacation> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {

        optionsBuilder.UseNpgsql("server=localhost;database=SafariVacation");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");
    }
  }
}
