using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniBlog.Models
{
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Email { get; set; }

        public ICollection<Post> Posts { get; set; }
        
    }
}
