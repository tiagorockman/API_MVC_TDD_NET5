
using CursoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace Models
{
    public class Context : DbContext
    {
        /// <summary>
        /// Transformei as propriedades Categorias e Produtos para vistuais pois estava retornando
        /// erro ao executar os testes no Moq. 
        /// Elas precisam ser overridable ou seja possíveis de serem sobrescritas
        /// </summary>
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        // Muda o status do objeto passado para modificado
        public virtual void SetModifield(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}