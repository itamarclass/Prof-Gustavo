using AmazingChocolate.DomainModel.Entities;
using AmazingChocolate.DomainModel.Interfaces.Repositories;
using AmazingChocolate.Infrastructure.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingChocolate.Infrastructure.DataAccess.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {

        private readonly AmazingChocolateContext _db;

        public ProdutoRepository(AmazingChocolateContext db) 
        {
            _db = db;
        }

        public void Create(Produto entity)
        {
            _db.Produtos.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
            _db.SaveChanges();
        }

        public IEnumerable<Produto> FindByName(string name)
        {

            return _db.Produtos.AsNoTracking()
                .Where(pro => EF.Functions
                .Like(pro.NomeProduto, $"%{name}%"));
        }

        //public async Task<IList<Produto>> GetProdutos()
        //{
        //    return  await  _db.Produtos.ToListAsync();
        //}

        public Produto Read(Guid id)
        {
            return _db.Produtos.AsNoTracking().Where(p => p.Id == id).SingleOrDefault();
        }

        public IEnumerable<Produto> ReadAll()
        {
            return _db.Produtos.AsNoTracking();
        }

        public void Update(Produto entity)
        {

            _db.Produtos.Update(entity);
            _db.SaveChanges();
        }
    }
}
