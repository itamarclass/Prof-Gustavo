using AmazingChocolate.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingChocolate.DomainModel.Interfaces.Repositories
{
    public interface IClienteRepository : IRepository<Cliente,Guid>
    {

        IEnumerable<Cliente> FindByName(string name);
        IEnumerable<Cliente> FindByEmail(string email);
    }
}
