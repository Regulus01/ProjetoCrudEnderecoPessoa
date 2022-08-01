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

        public Task<PessoaVO> Create(PessoaVO vo)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaVO> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaVO> FindAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PessoaVO> FindById(Guid id)
        {
            Pessoa pessoa = await _context.Pessoas
                                    .Include(x => x.Endereco)
                                    .Where(p => p.PessoaId == id)
                                    .FirstOrDefaultAsync();

            return _mapper.Map<PessoaVO>(pessoa);        
        }

        public Task<PessoaVO> Update(PessoaVO vo)
        {
            throw new NotImplementedException();
        }
    }
}
