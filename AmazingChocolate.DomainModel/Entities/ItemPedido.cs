using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingChocolate.DomainModel.Entities
{
    public class ItemPedido : EntityBase<Guid>
    {
       
               
        public Produto Produto { get;  set; }
      
        public int Quantidade { get;  set; }
        
        public decimal PrecoUnitario { get;  set; }
       
        public decimal Subtotal => Quantidade * PrecoUnitario;

    }
}
