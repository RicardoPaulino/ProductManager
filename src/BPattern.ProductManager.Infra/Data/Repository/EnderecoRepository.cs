using BPattern.ProductManager.Business.Models.Fornecedores;
using BPattern.ProductManager.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPattern.ProductManager.Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        //public EnderecoRepository(PMContext context) : base(context)
        //{

        //}
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            // O id do endereço e do fornecedor são os mesmos 
            return await ObterPorId(fornecedorId);
        }
    }
}
