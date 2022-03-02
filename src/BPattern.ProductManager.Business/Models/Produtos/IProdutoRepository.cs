using BPattern.ProductManager.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BPattern.ProductManager.Business.Models.Produtos
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornececdorId);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}
