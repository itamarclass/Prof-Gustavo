using System;
using System.Collections.Generic;
using System.Text;
namespace AmazingChocolate.DomainModel.Entities
{
    public class Pedido : EntityBase<Guid>

    {



        public Cliente Cliente { get; set; } 

        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();
        
       
    }
}