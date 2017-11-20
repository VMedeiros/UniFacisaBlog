using System;
using System.Linq;
using UniBlog.Dados;
using UniBlog.Models;

namespace UniBlog.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BlogContext context)
        {
            context.Database.EnsureCreated();

            if (context.Areas.Any())
            {
                return;
            }

            var areas = new Area[]
            {
            new Area{AreaID= 00, Nome="Sistemas de Informação"},
            new Area{AreaID= 01, Nome="Jogos Digitais"},
            new Area{AreaID= 02, Nome="Medicina"}
            };
            foreach (Area a in areas)
            {
                context.Areas.Add(a);
            }
            context.SaveChanges();

            var usuarios = new Usuario[]
            {
            new Usuario{UsuarioID=1513, Nome="Victor", DataCadastro=DateTime.Parse("2017-11-20"), Email="victor@gmail.com"},
            new Usuario{UsuarioID=1514, Nome="Adriano", DataCadastro=DateTime.Parse("2017-11-15"), Email="adriano@gmail.com"},
            };
            foreach (Usuario u in usuarios)
            {
                context.Usuarios.Add(u);
            }
            context.SaveChanges();

            var posts = new Post[]
            {
            new Post{UsuarioID=1513, AreaID= 00},
            new Post{UsuarioID=1514, AreaID= 02}
            };
            foreach (Post p in posts)
            {
                context.Posts.Add(p);
            }
            context.SaveChanges();

        var comentarios = new Comentario[]
            {
            new Comentario{ComentarioID=15, Texto="E meu TCC???"},
            new Comentario{ComentarioID=15, Texto="CORRIGI!!!"}
            };
            foreach (Comentario c in comentarios)
            {
                context.Comentarios.Add(c);
            }
            context.SaveChanges();
        }
    }
}