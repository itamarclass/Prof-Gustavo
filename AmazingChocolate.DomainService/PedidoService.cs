using AmazingChocolate.DomainModel.Entities;
using AmazingChocolate.DomainModel.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingChocolate.DomainService
{
    public class PedidoService
    {

        private IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        
        public void AddPedido(Pedido pedido)
        {
            _pedidoRepository.Create(pedido);
        }

        public IEnumerable<Pedido> GetAllPedidos()
        {
            return _pedidoRepository.ReadAll();
        }

        public Pedido GetPedidoById(Guid id)
        {
            return _pedidoRepository.Read(id);
        }

      


    }
}
