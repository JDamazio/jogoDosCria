using System.Collections.Generic;

namespace API.Models
{
    public class Nivel
    {
        public int Id { get; set; }

        public int Fase { get; set; }
        public int Boss { get; set; }

         //public virtual ICollection<Personagem> Personagens { get; set; }
    }
}