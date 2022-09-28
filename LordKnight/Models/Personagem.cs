using System;
using System.Collections.Generic;

namespace API.Models
{
    public class Personagem
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public int Dano { get; set; }

        public User User { get; set; }
        public Nivel Nivel {get; set;}
    

    }
}