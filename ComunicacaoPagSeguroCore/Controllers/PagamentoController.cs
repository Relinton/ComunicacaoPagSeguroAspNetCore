using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComunicacaoPagSeguroCore.Controllers
{
    public class PagamentoController : Controller
    {
        public IActionResult Realizar()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Retorno(FormCollection collection)
        //{
        //    var teste2 = new Teste()
        //    {
        //        Cod = "TransacaoID",
        //        Id = 354684,
        //        Status = "StatusTransacao"
        //    };

        //    AddTeste(teste2); //utilizei para saber se chega até aqui!

        //    string TransacaoID = collection["TransacaoID"];
        //    string StatusTransacao = collection["StatusTransacao"];

        //    var teste = new Teste()
        //    {
        //        Cod = TransacaoID,
        //        Id = 354684,
        //        Status = StatusTransacao
        //    };


        //    AddTeste(teste);

        //    return null;
        //}
    }
}
