using CrudPessoaEndereco.PessoaAPI.Data.ValueObjects;

namespace CrudPessoaEndereco.PessoaAPI.Repository
{
    public interface IPessoaRepository
    {
        Task<IEnumerable<PessoaVO>> FindAll();
        Task<PessoaVO> FindById(Guid id);
        Task<CreatePessoaVO> Create(CreatePessoaVO vo);
        Task<PessoaVO> Update(PessoaVO vo);
        Task<PessoaVO> Delete(Guid id);
    }
}
