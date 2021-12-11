using System.Linq;
using System.Collections.Generic;
using Autoglass.Domain.Entities;
using Autoglass.Domain.Interfaces;
using Autoglass.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Autoglass.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        private readonly Produto _produto;
        private readonly IRepository<Produto> _produtoRepository;

        public ProdutoController(Produto produto, IRepository<Produto> produtoRepository)
        {
            _produto = produto;
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public IList<Produto> ListarProdutos()
        {
            var produtos = _produtoRepository.Listar();
            return produtos;
        }

        [HttpGet("{id}")]
        public Produto BuscarPorId(int id)
        {
            var produto = _produtoRepository.BuscarPorID(id);
            return produto;
        }

        // POST: api/ToDoItems
        [HttpPost]
        public IActionResult Post([FromBody] ProdutoModel item)
        {
            var produto = new Produto()
            {
                Descricao = item.Descricao,
                DataValidade = item.DataValidade,
                DataFabricacao = item.DataFabricacao,   
                Situacao = item.Situacao
            };

            _produtoRepository.Inserir(produto);

            return Ok();
        }

        // POST: 
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] ProdutoModel item)
        {
            var produto = new Produto()
            {
                Id = id,
                Descricao = item.Descricao,
                DataValidade = item.DataValidade,
                DataFabricacao = item.DataFabricacao,
                Situacao = item.Situacao
            };

            _produtoRepository.Editar(produto);

            return Ok();
        }

        // POST: 
        [HttpPatch("{id}/Excluir")]
        public IActionResult Patch(int id)
        {
            _produtoRepository.Excluir(id);

            return Ok();
        }
    }
}
