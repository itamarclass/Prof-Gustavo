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
    public class ClienteRepository : IClienteRepository
    {

        private readonly AmazingChocolateContext _db;


        public ClienteRepository(AmazingChocolateContext db)
        {
            _db = db;
        }

        public void Create(Cliente entity)
        {
            _db.Clientes.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _db.Remove(Read(id));
            _db.SaveChanges();

        }

        public IEnumerable<Cliente> FindByName(string name)
        {
            return _db.Clientes.AsNoTracking()
               .Where(cli => EF.Functions
               .Like(cli.NomeCliente, $"%{name}%"));
        }
        public IEnumerable<Cliente> FindByEmail(string email)
        {
            return _db.Clientes.AsNoTracking()
               .Where(cli => EF.Functions
               .Like(cli.Email, $"%{email}%"));
        }
        public Cliente Read(Guid id)
        {
            return _db.Clientes.Find(id);
        }

        public IEnumerable<Cliente> ReadAll()
        {
            return _db.Clientes.AsNoTracking();
        }

        public void Update(Cliente entity)
        {
            _db.Clientes.Update(entity);
            _db.SaveChanges();
        }
    }
}
