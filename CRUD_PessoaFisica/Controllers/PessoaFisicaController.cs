using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http.Results;
using System.Web.Http;
using System.Web.Mvc;
using CRUD_PessoaFisica.Models;

namespace CRUD_PessoaFisica.Controllers
{
    public class PessoaFisicaController : Controller
    {
        private PessoaApiController api = new PessoaApiController();

        // PessoaFisica
        public ActionResult Index()
        {
            IHttpActionResult resultFromApi = api.Get();                                          
            if (resultFromApi is OkNegotiatedContentResult<List<PessoaFisicaModel>>)              
            {
                // Extrair a mensagem de retorno
                var result = resultFromApi as OkNegotiatedContentResult<List<PessoaFisicaModel>>;
                List<PessoaFisicaModel> content = result.Content;
                return View(content.ToList());
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

        // PessoaFisica/Details/{id}
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                int idValue = id.Value;
                IHttpActionResult resultFromApi = api.Get(idValue);                                           
                if (resultFromApi is OkNegotiatedContentResult<PessoaFisicaModel>)                            
                {
                    // Extrair a mensagem de retorno
                    var result = resultFromApi as OkNegotiatedContentResult<PessoaFisicaModel>;
                    PessoaFisicaModel content = result.Content;
                    return View("Details", content);
                }
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        // PessoaFisica/Edit/{id}
        public ActionResult Edit([Bind(Include = "Id,NomeCompleto,DataNascimento,ValorRenda,CPF")] PessoaFisicaModel pessoaFisicaModel)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else if (pessoaFisicaModel.NomeCompleto == null)
            {
                IHttpActionResult resultFromApi = api.Get(pessoaFisicaModel.Id);                                           
                if (resultFromApi is OkNegotiatedContentResult<PessoaFisicaModel>)                            
                {
                    // Extrair a mensagem de retorno
                    var result = resultFromApi as OkNegotiatedContentResult<PessoaFisicaModel>;
                    PessoaFisicaModel content = result.Content;
                    return View("Edit", content);
                }
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                IHttpActionResult resultFromApi = api.Put(pessoaFisicaModel.Id, pessoaFisicaModel);
                return RedirectToAction("Index");
            }
        }

        // PessoaFisica/Delete/{id}
        public ActionResult Delete(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                IHttpActionResult resultFromApi = api.Delete(id);
                return RedirectToAction("Index");
            }
        }

        // PessoaFisica/Create        

        public ActionResult Create(PessoaFisicaModel pessoaFisicaModel)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }else if(pessoaFisicaModel.NomeCompleto == null)
            {
                return View();
            }
            else
            {
                IHttpActionResult resultFromApi = api.Post(pessoaFisicaModel);                      
                return RedirectToAction("Index");                
            }
        }
    }
}
