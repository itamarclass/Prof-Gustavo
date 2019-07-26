using AmazingChocolate.DomainModel.Entities;
using AmazingChocolate.DomainModel.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmazingChocolate.DomainService
{
    public class ClienteService
    {


        private IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void AddCliente(Cliente cliente)
        {
            _clienteRepository.Create(cliente);
        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            return _clienteRepository.ReadAll();
        }

        public Cliente GetClienteById(Guid id)
        {
            return _clienteRepository.Read(id);
        }

        public IEnumerable<Cliente> SearchByName(string name)
        {
            return _clienteRepository.ReadAll()
                .Where(c => c.NomeCliente.ToLower()
                .Contains(name.ToLower()));
        }

        public IEnumerable<Cliente> SearchByEmail(string email)
        {
            return _clienteRepository.ReadAll()
                .Where(c => c.Email.ToLower()
                .Contains(email.ToLower()));
        }

    }
}
