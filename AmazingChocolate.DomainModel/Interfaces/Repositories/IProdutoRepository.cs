using AmazingChocolate.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazingChocolate.DomainModel.Interfaces.Repositories
{
   

    public interface IProdutoRepository : IRepository<Produto, Guid>
    {
        IEnumerable<Produto> FindByName(string name);
        
    }
}
