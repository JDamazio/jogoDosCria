using System;
using System.Collections.Generic;

namespace API.Models
{
    public class Personagem
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public int Dano { get; set; }

        public virtual Nivel Nivel { get; set; }
        public int NivelId { get; set; }

        public virtual User User { get; set; }
        public int UserId { get; set; }

    }
}