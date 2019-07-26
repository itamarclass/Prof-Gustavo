using AmazingChocolate.DomainModel.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmazingChocolate.DomainModel.Entities
{
    public class Cliente : EntityBase<Guid>
    {

        //public List<Pedido> Pedido { get; set; } = new List<Pedido>();        

        [Required]
        public string Senha { get; set; } = "";

        public string NomeCliente { get; set; } = "";

        [Required]
        public string Email { get; set; } = "";
        
        public string Telefone { get; set; } = "";
        
        public string Endereco { get; set; } = "";
        
        public string Complemento { get; set; } = "";
        
        public string Bairro { get; set; } = "";
        
        public string Municipio { get; set; } = "";
        
        public string UF { get; set; } = "";

        public string CPF { get; set; } = "";

        //public CEP CEP { get; set; }
        public string CEP { get; set; } = "";

        public List<Pedido> Pedido { get; set; } = new List<Pedido>();

    }
}
