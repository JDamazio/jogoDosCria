using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Models
{
    //Entity Framework Code First
    //É a classe que define a estrutura do banco de dados
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options) { }

        //Definir quais as classes de modelo servirão para as         
        //tabelas no banco de dados
        public DbSet<User> Usuario { get; set; }
        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<Nivel> Nivel { get; set; }
    }
}