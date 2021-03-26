using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;
using SysGames.Models;

namespace SysGames.Dal
{
    public class SysGamesInitializer : DropCreateDatabaseIfModelChanges<SysGamesContext>
    {
        protected override void Seed(SysGamesContext context)
        {
            var clientes = new List<Cliente>()
            {
                new Cliente()
                {
                    ClienteID = 1,
                    CPF = "11111111111",
                    Nome = "Andressa",
                    Email = "andressa@gmail.com",
                    Senha = "1234",
                    Logradouro = "Rua das flores",
                    Numero = "1234",
                    Bairro = "Jardim das flores",
                    Complemento = "Casa",
                    CEP = "11222333",
                    Localidade = "Araraquara",
                    UF = "SP",
                    DataNascimento = DateTime.Now,
                    Telefone = "16123456789"
                },
                new Cliente()
                {
                    ClienteID = 2,
                    CPF = "22222222222",
                    Nome = "Leonardo Lindo de Morrer",
                    Email = "gmail.com@miauleo",
                    Senha = "4321",
                    Logradouro = "Flores das ruas",
                    Numero = "4321",
                    Bairro = "Flores do jardim",
                    Complemento = "Asac",
                    CEP = "33322211",
                    Localidade = "Arauqarara",
                    UF = "PS",
                    DataNascimento = DateTime.Now,
                    Telefone = "98765432161"
                }
            };

            var videogames = new List<Videogame>()
            {
                new Videogame()
                {
                    ProdutoID = 1,
                    Nome = "Playstation 5",
                    Descricao = "HD 1TB, SSD 120GB",
                    Valor = 4999.90f,
                    QtdEstoque = 5,
                    Marca = "Sony",
                    Modelo = "Edição com disco"
                },
                new Videogame()
                {
                    ProdutoID = 4,
                    Nome = "Xbox Series X",
                    Descricao = "HD 1TB, SSD 120GB",
                    Valor = 3499.90f,
                    QtdEstoque = 5,
                    Marca = "Microsoft",
                    Modelo = "Serie X"
                }
            };

            var jogos = new List<Jogo>()
            {
                new Jogo()
                {
                    ProdutoID = 2,
                    Nome = "The last of us 2",
                    Descricao = "Jogo foda",
                    Valor = 399.90f,
                    QtdEstoque = 7,
                    Genero = "Suspense"
                },
                new Jogo()
                {
                    ProdutoID = 5,
                    Nome = "AFIF 12",
                    Descricao = "Nem lançou",
                    Valor = 699.90f,
                    QtdEstoque = 7,
                    Genero = "Esportes"
                }
            };

            var acessorios = new List<Acessorio>()
            {
                new Acessorio()
                {
                    ProdutoID = 3,
                    Nome = "Controle PS5",
                    Descricao = "Funciona bem",
                    Valor = 599.90f,
                    QtdEstoque = 7,
                },
                new Acessorio()
                {
                    ProdutoID = 6,
                    Nome = "Controle Xbox Series",
                    Descricao = "Funciona péssimo",
                    Valor = 449.90f,
                    QtdEstoque = 5,
                }
            };

            var vendas = new List<Venda>()
            {
                new Venda()
                {
                    VendaID = 1,
                    DataHora = DateTime.Now,
                    Previsao = DateTime.ParseExact("2021/03/30", "yyyy/MM/dd", CultureInfo.InvariantCulture),
                    Pagamento = new Pagamento ()
                    {
                        Carrinho = new Carrinho()
                        {
                            CarrinhoID = 1,
                            Produto = videogames[0],
                            Cliente = clientes[0],
                        },
                    },
                },
                new Venda()
                {
                    VendaID = 2,
                    DataHora = DateTime.Now,
                    Previsao = DateTime.ParseExact("2021/03/30", "yyyy/MM/dd", CultureInfo.InvariantCulture),
                    Pagamento = new Pagamento ()
                    {
                        Carrinho = new Carrinho()
                        {
                            CarrinhoID = 2,
                            Produto = videogames[1],
                            Cliente = clientes[1],
                        },
                    },
                }
            };
            clientes.ForEach(c => context.Clientes.Add(c));
            videogames.ForEach(v => context.Videogames.Add(v));
            jogos.ForEach(j => context.Jogos.Add(j));
            acessorios.ForEach(a => context.Acessorios.Add(a));
            vendas.ForEach(v => context.Vendas.Add(v));
            context.SaveChanges();
        }
    }
}