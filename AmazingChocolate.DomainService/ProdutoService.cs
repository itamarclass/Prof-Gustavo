using AmazingChocolate.DomainModel.Entities;
using AmazingChocolate.DomainModel.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmazingChocolate.DomainService
{
    public class ProdutoService
    {

        private IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void AddProduto(Produto produto)
        {
            _produtoRepository.Create(produto);
        }

        public IEnumerable<Produto> GetAllProdutos()
        {
            return _produtoRepository.ReadAll();
        }

        public Produto GetProdutoById(Guid id)
        {
            return _produtoRepository.Read(id);
        }

        public IEnumerable<Produto> SearchByName(string name)
        {
            return _produtoRepository.ReadAll()
                .Where(c => c.NomeProduto.ToLower()
                .Contains(name.ToLower()));
        }



    }
}
