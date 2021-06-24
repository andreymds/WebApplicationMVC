using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }        
        [Range(1,10, ErrorMessage ="Valor fora da faixa")] //define min e máx do input
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
    }
}
