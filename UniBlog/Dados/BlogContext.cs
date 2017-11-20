using UniBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace UniBlog.Dados
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Post>().ToTable("Post");
            modelBuilder.Entity<Area>().ToTable("Area");
            modelBuilder.Entity<Comentario>().ToTable("Comentario");
        }
    }
}

