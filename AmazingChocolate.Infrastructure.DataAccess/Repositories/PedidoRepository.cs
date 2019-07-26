using AmazingChocolate.DomainModel.Entities;
using AmazingChocolate.DomainModel.Interfaces.Repositories;
using AmazingChocolate.Infrastructure.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmazingChocolate.Infrastructure.DataAccess.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {

        private readonly AmazingChocolateContext _db;


        public PedidoRepository(AmazingChocolateContext db)
        {
            _db = db;
        }


        public void Create(Pedido entity)
        {
            _db.Pedidos.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
            _db.SaveChanges();
        }

        public Pedido Read(Guid id)
        {
            return _db.Pedidos.AsNoTracking().Where(p => p.Id == id).SingleOrDefault();
        }

        public IEnumerable<Pedido> ReadAll()
        {
            return _db.Pedidos.AsNoTracking();
        }

        public void Update(Pedido entity)
        {
            _db.Pedidos.Update(entity);
            _db.SaveChanges();
        }
    }
}
