using Microsoft.AspNetCore.Mvc;
using desafio_negocie_online_back_end.Models;
using desafio_negocie_online_back_end.Services;

namespace desafio_negocie_online_back_end.Controllers{
    [ApiController]
    [Route("[controller]")]

    public class CEPController: ControllerBase{
        public CEPController(){}

        [HttpGet("{codeCep}")]
        public ActionResult<CEP> Get(string codeCep){
            var cep = CEPService.Get(codeCep);

            if(cep == null) return NotFound();

            return cep;
        }

        [HttpPost]
        public IActionResult Create(CEP cep){
            var verifyCep = CEPService.Get(cep.cep);

            if(verifyCep != null) return Conflict();

            CEPService.Add(cep);

            return CreatedAtAction(nameof(Create), new { cep = cep.cep }, cep);
        }
    }
}
