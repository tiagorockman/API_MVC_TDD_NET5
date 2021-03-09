using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
        [Range(1, 10, ErrorMessage ="Valor fora da quantidade permitida.")]
        public int Quantidade { get; set; }

        //Relacionamento
       public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
