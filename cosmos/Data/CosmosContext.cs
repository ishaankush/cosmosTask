using Microsoft.EntityFrameworkCore;
using cosmos.Models;

namespace cosmos.Data;

public class CosmosContext : DbContext
{
    public DbSet<Detail>? Details { get; set; }
    public DbSet<Template>? Templates { get; set; }
    public DbSet<Webflow>? Webflows { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseCosmos(
            "https://abhikushtask-db.documents.azure.com:443/",
            "serA4b05B6LsYxfHrMMxKVQgBp4hqHPS0mob13081dJ0jE7lihDh7mGvGut4qrkmHSJkWEHOHzNaACDbBDKOCQ==",
            "abhikushtask");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // configuring detail
        modelBuilder.Entity<Detail>()
                .ToContainer("Details") // ToContainer
                .HasPartitionKey(e => e.Id); // Partition Key
        modelBuilder.Entity<Template>()
                .ToContainer("Templates") // ToContainer
                .HasPartitionKey(e => e.Id); // Partition Key
        modelBuilder.Entity<Webflow>()
                .ToContainer("Webflows") // ToContainer
                .HasPartitionKey(e => e.Id); // Partition Key

    }

}



