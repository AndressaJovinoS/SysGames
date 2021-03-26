using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class Cliente
	{
		[Required(ErrorMessage = "Cliente inválido")]
		public int ClienteID { get; set; }
		public string CPF { get; set; }
		public string Nome { get; set; }
		[Display(Name = "Data de Nascimento")]
		public DateTime DataNascimento { get; set; }
		public string Telefone { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public string Logradouro { get; set; }
		public string Bairro { get; set; }
		public string Localidade { get; set; }
		public string UF { get; set; }
		public string CEP { get; set; }
		public string Complemento { get; set; }
		[Display(Name = "Número")]
		public string Numero { get; set; }

	}
}