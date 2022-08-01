using CrudPessoaEndereco.PessoaAPI.Data.ValueObjects;
using CrudPessoaEndereco.PessoaAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CrudPessoaEndereco.PessoaAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PessoaController : Controller
    {
        private readonly IPessoaRepository _repository;

        public PessoaController(IPessoaRepository repository)
        {
            _repository = repository ?? throw new 
                ArgumentException(null, nameof(repository));
        }

        /// <summary>
        ///     EndPoint para criar endereço
        /// </summary>
        /// <remarks>
        ///     End point que cria pessoa a partir dos dados passados no value object
        /// </remarks>>
        /// <param name="vo"></param>
        /// <returns>
        ///     Retorna a pessoa criada 
        /// </returns>
        /// <response code="200">Retorna o usuário criado</response>>
        /// <response code="400">BadRequest, erro na requisição</response>>
        [HttpPost]
        public async Task<ActionResult<PessoaVO>> Create([FromBody] CreatePessoaVO? vo)
        {
            if (vo == null) return BadRequest();
            var pessoa = await _repository.Create(vo);
            return Ok(pessoa);
        }

        /// <summary>
        ///     EndPoint filtrar todas as pessoas
        /// </summary>
        /// <remarks>
        ///     EndPoint filtrar todas as pessoas cadastradas no banco de dados
        /// </remarks>>
        /// <returns>
        ///     Retorna tododas as pessoas do banco
        /// </returns>
        /// <response code="200">Retorna os usuários</response>>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PessoaVO>>> FindAll()
        {
            var pessoas = await _repository.FindAll();

            return Ok(pessoas);
        }

        /// <summary>
        ///     EndPoint para filtrar uma pessoa pelo id
        /// </summary>
        /// <remarks>
        ///     End point que retorna uma pessoa pelo seu id (guid)
        /// </remarks>>
        /// <param name="id"></param>
        /// <returns>
        ///     Retorna a pessoa com o seu id correspondente
        /// </returns>
        /// <response code="200">Retorna o usuário do banco</response>>
        /// <response code="404">NotFound, usuário não encontrado</response>>
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<PessoaVO>> FindById(Guid? id)
        {
            var pessoa = await _repository.FindById(id);
            if (pessoa.Equals(null)) return NotFound();
            return Ok(pessoa);
        }
    }
}
