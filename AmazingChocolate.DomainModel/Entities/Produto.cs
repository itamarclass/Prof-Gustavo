using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingChocolate.DomainModel.Entities
{
    public class Produto : EntityBase<Guid>
    {

        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public string FotoProdutoURL { get; set; }
        public List<ItemPedido> ItemPedidos { get; set; } = new List<ItemPedido>();


    }
}
