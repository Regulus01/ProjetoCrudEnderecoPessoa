using CrudPessoaEndereco.PessoaAPI.Data.ValueObjects;

namespace CrudPessoaEndereco.PessoaAPI.Repository
{
    public interface IPessoaRepository
    {
        Task<PessoaVO> FindAll();
        Task<PessoaVO> FindById(Guid id);
        Task<PessoaVO> Create(PessoaVO vo);
        Task<PessoaVO> Update(PessoaVO vo);
        Task<PessoaVO> Delete(Guid id);
    }
}
