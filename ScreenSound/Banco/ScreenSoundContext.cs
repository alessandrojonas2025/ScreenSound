using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;


namespace ScreenSound.Banco
{
    public class ScreenSoundContext:DbContext
    {
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Musica> Musicas { get; set; }

        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ScreenSoundV0;User ID=sa;Password=Senha@2025;Connect Timeout=200;Application Name=ScreenSound;TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
        }


        //antigo OD.net
        /*
        public SqlConnection ObterConexao()
        {
            return new SqlConnection(connectionString);
        }
        */


       



    }
}
