using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class Jogo : Produto
	{
		[Display(Name = "Gênero")]
		public string Genero { get; set; }
		[Display(Name = "Classificação")]
		public string Classificacao { get; set; }

		public Jogo()
		{
			Tipo = "Jogo";
		}
	}
}