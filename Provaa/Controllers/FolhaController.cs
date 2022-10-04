using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/folha")]

    public class FolhaController : ControllerBase
    {
        private readonly DataContext _context;
        public FolhaController(DataContext context) =>
            _context = context;

        //POST: /api/folha/cadastro
        [HttpPost]
        [Route("cadastro")]
        public IActionResult Cadastro([FromBody] FolhaPagamento folha) 
        {     
            //Calculo de Salario Bruto
            // folha.Salariobruto = FolhaPagamento.Valorhora * FolhaPagamento.Quantidadehoras;
            _context.Folhas.Add(folha);
            _context.SaveChanges();
            return Created("", folha);
            
        }

        // GET: /api/folha/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Folhas.ToList());

        // GET: /api/folha/buscar/{cpf}/{mês}/{ano}
        [HttpGet]
        [Route("buscar/{cpf}/{mes}/{ano}")]
        public IActionResult Buscar([FromRoute] string cpf)
        {
            try
            {
                Funcionario funcionario = _context.Funcionarios.
                FirstOrDefault(f => f.Cpf.Equals(cpf));
                return funcionario != null ? Ok(funcionario) : NotFound(); 
            }
            catch 
            {
                return NotFound();
            }
            
        }

        // GET: /api/folha/filtrar/{mes}/{ano}
        [HttpGet]
        [Route("filtrar/{mes}/{ano}")]
        public IActionResult Filtrar([FromRoute] string cpf)
        {
            try
            {
                Funcionario funcionario = _context.Funcionarios.
                FirstOrDefault(f => f.Cpf.Equals(cpf));
                return funcionario != null ? Ok(funcionario) : NotFound(); 
            }
            catch 
            {
                return NotFound();
            }
            
        }
        
        // DELETE: /api/folha/deletar/{id}
        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            FolhaPagamento folhaPagamento = _context.Folhas.Find(id);
            if (folhaPagamento != null)
            {
                _context.Folhas.Remove(folhaPagamento);
                _context.SaveChanges();
                return Ok(folhaPagamento);
            }
            return NotFound();
        }
    }
}
