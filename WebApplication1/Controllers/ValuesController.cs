using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly List<NaujaKlase> _list;

        public ValuesController()
        {
            _list = new List<NaujaKlase>();
            string Stars = "";

            for(int i = 1; i <= 5; i++)
            {
                for(int a = 1; a <= i; a++){
                Stars += '*';
            }
                    Stars += System.Environment.NewLine;
            }
            _list.Add(new NaujaKlase
            {
                Id = 1,
                Value = Stars
            });
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            return Ok(_list);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            NaujaKlase found = _list.FirstOrDefault(x => x.Id == id);

            if (found == null) return NotFound();

            return Ok(found);
        }

        [HttpPost]
        public IActionResult Create(NaujaKlase request)
        {
            _list.Add(request);

            return Ok(request);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            NaujaKlase found = _list.FirstOrDefault(x => x.Id == id);

            if(found == null)
            {
                return NotFound();
            }

            _list.Remove(found);

            return Ok();
        }

        [HttpPut]
        public IActionResult Edit(int id, NaujaKlase request)
        {
            NaujaKlase found = _list.FirstOrDefault(x => x.Id == id);

            if (found == null)
            {
                return NotFound();
            }

            found.Value = request.Value;

            return Ok(found);
        }
    }

    public class NaujaKlase
    {
        public int Id { get; set; }

        public string Value { get; set; }
    }
}
