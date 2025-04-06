using API_Palusa.models;
using API_Palusa.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace API_Palusa.Controllers
{
    [ApiController]
    [Route("API/Estoque")]
    public class EstoqueController : ControllerBase
    {
        private readonly iestoqueRepository estoqueRepository;

        public EstoqueController(iestoqueRepository estoqueRepository)
        {
            this.estoqueRepository = estoqueRepository;
        }

        [HttpPost]
        public IActionResult add([FromBody] EstoqueViewModel estoqueview)
        {
            var estoque = new estoque(

                estoqueview.codigo, 
                estoqueview.descricao,
                estoqueview.marca,
                estoqueview.quantidade, 
                estoqueview.local);

            this.estoqueRepository.save(estoque);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get() {
            var estoque = estoqueRepository.Get();

            return Ok(estoque);
        }
    }
}
