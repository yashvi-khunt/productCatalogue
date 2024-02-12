using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace productCatalogue.Models
{
    public class CatalogueAPIContext: IdentityDbContext
    {
        CatalogueAPIContext() { }

        public CatalogueAPIContext(DbContextOptions<CatalogueAPIContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Tag> Tags { get; set; } = null!;
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Image> Images { get; set; } = null!;

    }
}
