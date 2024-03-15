using CardDeliveryService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CardDeliveryService.DataAccess.Contexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = $"Host=localhost;Port=5432;Database=postgres;User Id=hosting-db;Password=password;";
        optionsBuilder.UseNpgsql(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Card>()
            .HasOne(Card => Card.CardHolder)
            .WithMany(user => user.Cards)
            .HasForeignKey(Card => Card.CardHolderId);

        modelBuilder.Entity<User>()
            .HasMany(user => user.Cards)
            .WithOne(card => card.CardHolder)
            .HasForeignKey(card => card.CardHolderId);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Card> Cards { get; set; }
}
