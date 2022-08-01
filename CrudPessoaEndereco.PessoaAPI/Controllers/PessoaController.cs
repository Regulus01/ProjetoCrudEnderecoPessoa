using CrudPessoaEndereco.PessoaAPI.Data.ValueObjects;
using CrudPessoaEndereco.PessoaAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CrudPessoaEndereco.PessoaAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PessoaController : Controller
    {
        private IPessoaRepository _repository;

        public PessoaController(IPessoaRepository repository)
        {
            _repository = repository ?? throw new 
                ArgumentException(null, nameof(repository));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PessoaVO>> FindById(Guid id)
        {
            var pessoa = await _repository.FindById(id);
            if (pessoa == null) return NotFound();
            return Ok(pessoa);
        }
    }
}
