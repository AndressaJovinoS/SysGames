using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class Venda
	{
		public int VendaID { get; set; }
		public virtual Pagamento Pagamento { get; set; }
		[Display(Name = "Data Hora")]
		public DateTime DataHora { get; set; }
		[Display(Name = "Previsão de entrega")]

		[Required(ErrorMessage = "Data inválida")]
		public DateTime Previsao { get; set; }
	}
}