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

    public class FornecedorController : Controller
    {        

        private readonly Fornecedor _fornecedor;
        //private readonly IRepository<Fornecedor> _fornecedorRepository;
        private readonly IFornecedorRepository _fornecedorRepository;

        //public FornecedorController(Fornecedor fornecedor, IRepository<Fornecedor> fornecedorRepository)
        public FornecedorController(Fornecedor fornecedor, IFornecedorRepository fornecedorRepository)
        { 
            _fornecedor = fornecedor;
            _fornecedorRepository = fornecedorRepository;
        }

        [HttpGet]
        public IList<Fornecedor> ListarFornecedores()
        {
            var fornecedores = _fornecedorRepository.Listar();
            return fornecedores;
        }

        [HttpGet("{id}")]
        public Fornecedor BuscarPorId(int id)
        {
            var fornecedor = _fornecedorRepository.BuscarPorID(id);
            return fornecedor;
        }

        [HttpGet("busca/{descricao}")]
        public IList<Fornecedor> BuscarPorDescricao(string descricao)
        {
            var fornecedores = _fornecedorRepository.BuscarPorDescricao(descricao);
            return fornecedores;
        }

        // POST: api/ToDoItems
        [HttpPost]
        public IActionResult Post([FromBody] FornecedorModel item)
        {
            var fornecedor = new Fornecedor()
            {
                Descricao = item.Descricao,
                Cnpj = item.CNPJ,
                Tipo = item.Tipo,
                Situacao = item.Situacao
            };

            _fornecedorRepository.Inserir(fornecedor);

            return Ok();
        }

        // POST: 
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] FornecedorModel item)
        {
            var fornecedor = new Fornecedor()
            {
                Id = id,
                Descricao = item.Descricao,
                Cnpj = item.CNPJ,
                Tipo = item.Tipo,
                Situacao = item.Situacao
            };

            _fornecedorRepository.Editar(fornecedor);

            return Ok();
        }
        // POST: 
        [HttpPatch("{id}/Excluir")]
        public IActionResult Patch(int id)
        {
            _fornecedorRepository.Excluir(id);

            return Ok();
        }


    }
}
