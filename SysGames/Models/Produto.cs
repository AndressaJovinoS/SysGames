using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class Produto
	{
		[Display(Name = "ID do Produto")]
		[Required(ErrorMessage = "Produto inválido")]
		//[Range]
		public int ProdutoID { get; set; }
		public string Nome { get; set; }
		[Display(Name = "Descrição")]
		public string Descricao { get; set; }

		[Required(ErrorMessage = "Informe um valor válido")]
		public float Valor { get; set; }
		[Display(Name = "Quantidade de Estoque")]
		public int QtdEstoque { get; set; }
		public string Tipo { get; set; }
	}
}