using ComunicacaoPagSeguroCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComunicacaoPagSeguroCore.Controllers
{
    public class ProdutosController : Controller
    {
        private List<Produto> produtos;
        public List<Produto> Produtos
        {
            get
            {
                if (produtos == null)
                {
                    produtos = new List<Produto>();
                    produtos.Add(new Produto { Id = 1, Nome = "Livro Código limpo", Descricao = "Habilidades práticas do Agile Software", Valor = 70 });
                    produtos.Add(new Produto { Id = 2, Nome = "Notbook Samsung", Descricao = "Fabricante Samsung", Valor = 3000 });
                    produtos.Add(new Produto { Id = 3, Nome = "Guitarra Fender", Descricao = "Fabricante Fender Musical Instruments Corporation", Valor = 2000 });
                    return produtos;
                }
                else
                    return produtos;
            }
            set
            {
                produtos = value;
            }
        }

        public IActionResult Index()
        {
            return View(Produtos);
        }

        public IActionResult Detalhes(int id)
        {
            Produto produto = (from i in Produtos where i.Id == id select i).FirstOrDefault();
            return View(produto);
        }


        public IActionResult Retorno()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Retorno(FormCollection colecao)
        {
            return View();
        }
    }
}
