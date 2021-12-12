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
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(Produto produto, IProdutoRepository produtoRepository)
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

        [HttpPost("busca")]
        public IList<Produto> BuscarPorParametros([FromBody] ParametrosModel parametros)
        {
            var produtos = _produtoRepository.BuscarPorParametros(parametros.descricao, parametros.fornecedor, parametros.pageSize, parametros.page);
            return produtos;
        }


        [HttpPost]
        public IActionResult Post([FromBody] ProdutoModel item)
        {
            //validacao de data no domain vai disparar exceção. vou tratar aqui.
            try {
                var produto = new Produto(item.Descricao, item.DataFabricacao, item.DataValidade, item.IdFornecedor);

                _produtoRepository.Inserir(produto); 
            
            }
            catch (System.Exception e)
            {
                string errorMessage = e.Message;
                Response.Headers.Add("X-Error",errorMessage);
                return BadRequest();
            }
                
            return Ok();
        }

        // POST: 
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] ProdutoModel item)
        {
            //validacao de data no domain vai disparar exceção. vou tratar aqui.
            try
            {

                var original = _produtoRepository.BuscarPorID(id);

                original.Descricao = item.Descricao;
                original.DataValidade = item.DataValidade;
                original.DataFabricacao = item.DataFabricacao;
                original.IdFornecedor = item.IdFornecedor;
                

                _produtoRepository.Editar(original);
            }
            catch (System.Exception e)
            {
                string errorMessage = e.Message;
                Response.Headers.Add("X-Error", errorMessage);
                return BadRequest();
            }

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
