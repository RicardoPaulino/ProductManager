using BPattern.ProductManager.Business.Core.Models;
using BPattern.ProductManager.Business.Models.Produtos;
using System.Collections.Generic;

namespace BPattern.ProductManager.Business.Models.Fornecedores
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public ICollection<Produto> Produtos { get; set; }
    }
}
