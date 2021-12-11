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
        private readonly IRepository<Fornecedor> _fornecedorRepository;

        public FornecedorController(Fornecedor fornecedor, IRepository<Fornecedor> fornecedorRepository) 
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

        // POST: api/ToDoItems
        [HttpPost]
        public IActionResult Post([FromBody] FornecedorModel item)
        {
            var fornecedor = new Fornecedor()
            {
                Descricao = item.Descricao,
                Cnpj = item.CNPJ,
                Tipo = item.Tipo
            };

            _fornecedorRepository.Inserir(fornecedor);

            return Ok();
        }


    }
}
