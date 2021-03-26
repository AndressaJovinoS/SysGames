using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class Videogame : Produto
	{
		public string Marca { get; set; }
		public string Modelo { get; set; }

		public Videogame()
		{
			Tipo = "Console";
		}
	}
}