using DemoDevOpsAPI.Models;
using DemoDevOpsAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoDevOpsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesenvolvedorController : ControllerBase
    {
        private readonly IDesenvolvedorService _service;
        public DesenvolvedorController(IDesenvolvedorService service)
        {
            _service = service;
        }
        // GET api/Desenvolvedors
        [HttpGet]
        public ActionResult<IEnumerable<Desenvolvedor>> Get()
        {
            var items = _service.GetAllItems();
            return Ok(items);
        }
        // GET api/Desenvolvedors/5
        [HttpGet("{id}")]
        public ActionResult<Desenvolvedor> Get(int id)
        {
            var item = _service.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
        // POST api/Desenvolvedors
        [HttpPost]
        public ActionResult Post([FromBody] Desenvolvedor value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var item = _service.Add(value);
            return CreatedAtAction("Get", new { id = item.Id }, item);
        }
        // DELETE api/Desenvolvedors/5
        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            var existingItem = _service.GetById(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            _service.Remove(id);
            return Ok();
        }
    }
}
