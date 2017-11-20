using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniBlog.Models

{ 
 
public class Post
{
    public int PostId { get; set; }
    public int UsuarioID { get; set; }
    public int AreaID { get; set; }
    public int ComentarioID { get; set; }
    
    public ICollection<Comentario> Comentarios { get; set; }
    public Usuario Usuarios { get; set; }
    public Area Areas { get; set; }
}
}