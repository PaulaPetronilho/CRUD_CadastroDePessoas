using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using CRUD_PessoaFisica.Models;

namespace CRUD_PessoaFisica.Controllers
{
    public class PessoaApiController : ApiController
        {
            private PessoaDBContext db = new PessoaDBContext();

            [HttpGet]
            // GET: api/PessoaApi
            public IHttpActionResult Get()
            {
                var pessoasFisicas = db.Pessoa.ToList();
                return Ok(pessoasFisicas);
            }

            [HttpGet]
            // GET: api/PessoaApi/5
            public IHttpActionResult Get(int id)
            {
                var pessoaFisica = db.Pessoa.Find(id);
                if (pessoaFisica == null)
                {
                    return NotFound();
                }
                return Ok(pessoaFisica);
            }
            
            [HttpPost]
            // POST: api/PessoaApi
            public IHttpActionResult Post([FromBody] PessoaFisicaModel pessoaFisica)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                db.Pessoa.Add(pessoaFisica);
                db.SaveChanges();

                return CreatedAtRoute("DefaultApi", new { id = pessoaFisica.Id }, pessoaFisica);
            }

            [HttpPut]
            // PUT: api/PessoaApi/5
            public IHttpActionResult Put(int id, [FromBody] PessoaFisicaModel pessoaFisica)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (id != pessoaFisica.Id)
                {
                    return BadRequest();
                }

                db.Entry(pessoaFisica).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PessoaFisicaExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return StatusCode(HttpStatusCode.NoContent);
            }

            [HttpDelete]
            // DELETE: api/PessoaApi/5
            public IHttpActionResult Delete(int id)
            {
                var pessoaFisica = db.Pessoa.Find(id);
                if (pessoaFisica == null)
                {
                    return NotFound();
                }

                db.Pessoa.Remove(pessoaFisica);
                db.SaveChanges();

                return Ok(pessoaFisica);
            }

            private bool PessoaFisicaExists(int id)
            {
                return db.Pessoa.Any(e => e.Id == id);
            }
        }
    }
