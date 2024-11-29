using Livraria.Context;
using Livraria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Livraria.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class Editora_controller : ControllerBase
    {

        private readonly AppDbContext _context;

        public Editora_controller(AppDbContext context)
        {
            _context = context;
        }

        //###################################################
        //get para trazer lista de resultados 
        [HttpGet]
        public ActionResult<IEnumerable<Editora>> Get()
        {
            return _context.Editora.AsNoTracking().ToList();
        }

        //###################################################
        // get para trazer apenas um resulto informado o id
        [HttpGet("{id:int", Name = "ObterEditora")]
        public ActionResult<Editora> Get2(int id)
        {
            var editora = _context.Editora.FirstOrDefault(P => P.Id_Editora == id);

            if (editora is null)
            {
                return NotFound("Categoria não encontrada");
            }

            return Ok (editora);
        }

        //###################################################
        // post para criar uma nova categoria
        [HttpPost]
        public ActionResult Post(Editora editora)
        {
            if(editora is null)  return BadRequest();
           

            _context.Editora.Add(editora);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterEditora", new { id = editora.Id_Editora }, editora);
        }


        //###################################################
        // aqui para atualizar uma nova categoria.
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Editora editora)
        {
            if (editora is null) 
                return NotFound();

            if (id != editora.Id_Editora) 
            { return BadRequest(); }

            _context.Entry(editora).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(editora);
        }


        //###################################################
        // aqui para deletar uma categoria qu já está no banco. 
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {

            var editora = _context.Editora.FirstOrDefault(p => p.Id_Editora == id);

            if(editora is null)
                return NotFound();

            _context.Editora.Remove(editora);
            _context.SaveChanges();

            return Ok(editora);
        }
    }
}
