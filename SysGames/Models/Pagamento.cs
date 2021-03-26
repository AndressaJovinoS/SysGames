using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class Pagamento
	{
		[Display(Name = "ID do Pagamento")]
		public int PagamentoID { get; set; }
		public virtual Carrinho Carrinho { get; set; }
	}
}