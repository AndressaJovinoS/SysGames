using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
    [Table("Carrinhos")]
    public class Carrinho
    {
        [Display(Name = "ID do Carrinho")]
        public int CarrinhoID { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}