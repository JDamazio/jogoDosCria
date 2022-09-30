using System;
using System.Collections.Generic;


namespace API.Models
{
    public class User
    {
        public User() => CriadoEm = DateTime.Now;
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public DateTime CriadoEm { get; set; }

        //public virtual ICollection<Personagem> Personagens { get; set; }

    }
}