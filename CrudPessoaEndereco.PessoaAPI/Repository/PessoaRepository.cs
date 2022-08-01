using AutoMapper;
using CadastroPessoaEndereco.PessoaAPI.Model;
using CrudPessoaEndereco.PessoaAPI.Data.ValueObjects;
using CrudPessoaEndereco.PessoaAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace CrudPessoaEndereco.PessoaAPI.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public PessoaRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CreatePessoaVO> Create(CreatePessoaVO? vo)
        {
            Pessoa pessoa = _mapper.Map<Pessoa>(vo);
            _context.Pessoas?.Add(pessoa);

            if (pessoa.Endereco != null)
            {
                _context.Enderecos?.Add(pessoa.Endereco);
            }

            await _context.SaveChangesAsync();

            return _mapper.Map<CreatePessoaVO>(pessoa);
        }

        public Task<PessoaVO> Update(PessoaVO vo)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaVO> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PessoaVO>?> FindAll()
        {
            if (_context.Pessoas != null)
            {
                List<Pessoa> pessoas = await _context.Pessoas.Include(x => x.Endereco).ToListAsync();

                return _mapper.Map<List<PessoaVO>>(pessoas);
            }

            return null;
        }

        public async Task<PessoaVO?> FindById(Guid? id)
        {
            if (_context.Pessoas != null)
            {
                Pessoa pessoa = await _context.Pessoas
                    .Include(x => x.Endereco)
                    .Where(p => p.PessoaId == id)
                    .FirstOrDefaultAsync();

                return _mapper.Map<PessoaVO>(pessoa);
            }

            return null;
        }

 
    }
}
