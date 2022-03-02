using BPattern.ProductManager.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace BPattern.ProductManager.Business.Models.Fornecedores
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);

    }
}
