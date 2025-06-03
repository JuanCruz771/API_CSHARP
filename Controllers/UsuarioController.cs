using API_Palusa.models;
using API_Palusa.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace API_Palusa.Controllers
{
    [ApiController]
    [Route("API/Usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly iusuarioRepository usuarioRepository;

        public UsuarioController(iusuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        public IActionResult add([FromBody] UsuarioViewModel usuarioView)
        {
            var usuario = new usuario(

                usuarioView.login,
                usuarioView.senha);
                

            this.usuarioRepository.save(usuario);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var usuario = usuarioRepository.Get();

            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UsuarioViewModel vm)
        {
            var usuarioExistente = usuarioRepository.GetById(id);

            if (usuarioExistente == null)
                return NotFound();

            usuarioExistente.senha = vm.login;
            usuarioRepository.Update(usuarioExistente);

            return Ok(usuarioExistente);
        }
    }
}
