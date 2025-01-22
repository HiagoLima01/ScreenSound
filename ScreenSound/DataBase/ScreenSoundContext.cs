using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.DataBase
{
    internal class ScreenSoundContext : DbContext
    {
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Musica> Musicas { get; set; }
        private string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString).UseLazyLoadingProxies();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configuração de relacionamento 1:N entre Artista e Musica
        //    modelBuilder.Entity<Musica>()
        //        .HasOne(m => m.Artista)
        //        .WithMany(a => a.Musicas) // Certifique-se de que Artista tem a propriedade "Musicas"
        //        .HasForeignKey(m => m.Artista); // Adicione a chave estrangeira

        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
