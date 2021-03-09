using CursoMVC.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descri��o")]
        [Required(ErrorMessage ="O campo Descri��o � obrigat�rio.")]
        public string Descricao { get; set; }

        //relacionamento
      //  public List<Produto> Produtos { get; set; }

    }
}
