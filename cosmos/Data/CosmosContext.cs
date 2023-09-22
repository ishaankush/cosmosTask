using Microsoft.EntityFrameworkCore;
using cosmos.Models;

namespace cosmos.Data;

public class CosmosContext : DbContext
{
    public DbSet<Detail>? Details { get; set; }
   

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

    }

}



