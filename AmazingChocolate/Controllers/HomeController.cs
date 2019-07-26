using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AmazingChocolate.Models;
using AmazingChocolate.DomainModel.Interfaces.Repositories;
using AmazingChocolate.Infrastructure.DataAccess.Contexts;
using Microsoft.AspNetCore.Http;
using AmazingChocolate.DomainModel.Entities;
using Microsoft.EntityFrameworkCore;

namespace AmazingChocolate.Controllers
{
    public class HomeController : Controller
    {

        private readonly AmazingChocolateContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IClienteRepository _clienteRepository;
        private readonly IProdutoRepository _produtorespository;
        private readonly IPedidoRepository _pedidorepository;
        private ISession _sessao => _httpContextAccessor.HttpContext.Session;


        public HomeController(IHttpContextAccessor httpContextAccessor,
             IClienteRepository clienteRepository,
              IProdutoRepository produtorespository,
             AmazingChocolateContext contexto,
             IPedidoRepository pedidorepository
            )
        {
            
            this._httpContextAccessor = httpContextAccessor;
            this._clienteRepository = clienteRepository;
            this._produtorespository = produtorespository;
            this._pedidorepository = pedidorepository;

            _context = contexto;
        }

        

        public IActionResult Index()
        {
            
            return View(_produtorespository.ReadAll().ToList());
        }
        public IActionResult Wellcome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Wellcome(string email,string senha)
        {
            Cliente cliente = new Cliente();
            cliente = _clienteRepository.FindByEmail(email).SingleOrDefault();
                //(_context.Clientes.Where(c => c.Email == email).FirstOrDefault().Id);
               
            if (cliente ==null)
            {
                return View();
            }
            if (cliente.Senha == senha)
            {
                _sessao.Set<Cliente>("cliente",cliente);
                _sessao.Set<Guid>("pedidoId",Guid.NewGuid());

                return RedirectToAction("index");
            }
            else
            {
                return View();
            }

            
        }

        [HttpPost]
        public IActionResult AdicionarProduto(Guid produto, string quantidade)
        {

            var itempedido = new ItemPedido();
            var pedido = new Pedido();
            var prod = new Produto();

            prod = _produtorespository.Read(produto);
                //_context.Produtos.Find(_context.Produtos.Where(p => p.Id == produto).SingleOrDefault().Id);
                     
            pedido.Cliente = _sessao.Get<Cliente>("cliente");
            pedido.Id = _sessao.Get<Guid>("pedidoId");
            
            itempedido.Quantidade = int.Parse(quantidade);
            itempedido.Id = Guid.NewGuid();
            itempedido.PrecoUnitario = prod.Preco;
            itempedido.Produto = prod;
            
            pedido.Itens.Add(itempedido);

            //_clienteRepository.Delete(pedido.Cliente.Id);
            _clienteRepository.Update(pedido.Cliente);
            //_produtorespository.Delete(prod.Id);
            _produtorespository.Update(prod);

            _pedidorepository.Create(pedido);



            return RedirectToAction("Index");
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
