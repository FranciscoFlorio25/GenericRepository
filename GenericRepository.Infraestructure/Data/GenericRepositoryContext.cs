using GenericRepository.Application.Data;
using GenericRepository.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Infraestructure
{
    public class GenericRepositoryContext : DbContext, IGenericRepositoryContext
    {
        public GenericRepositoryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers => Set<Customer>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>();
        }

    }
}
