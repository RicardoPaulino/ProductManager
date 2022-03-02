using BPattern.ProductManager.Business.Core.Models;
using BPattern.ProductManager.Business.Models.Fornecedores;
using System;

namespace BPattern.ProductManager.Business.Models.Produtos
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public Fornecedor Fornecedor { get; set; }
    }
}
