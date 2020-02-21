using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Senai.People.WebApi.Domains;
using Senai.People.WebApi.Interfaces;
using Senai.People.WebApi.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Senai.People.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]")]
    [ApiController]

    public class FuncionariosController : ControllerBase
    {
        private IFuncionariosRepository _funcionariosRepository { get; set; }
        public string StringConexao { get; private set; }

        public FuncionariosController()
        {
            _funcionariosRepository = new FuncionariosRepository();
        }
   
        //////////////////////////////////////////////////////////////////////////////////////////
        //LISTAR

        [HttpGet]
        public IEnumerable<FuncionariosDomains> Get()
        {
            return _funcionariosRepository.SelectAll();
        }

        /////////////////////////////////////////////////////////////////////////////////////////
        //SELECIONAR POR ID

        [HttpGet("{id}")]
        public IActionResult SelectById(int id)
        {
            FuncionariosDomains funcionarioBuscado = _funcionariosRepository.SelectById(id); 
            
            if (funcionarioBuscado == null)
            {
                return NotFound("Funcionario não encontardo");
            }
            return Ok(funcionarioBuscado);
        }
    }
}
//////////////////////////////////////////////////////////////////////////////////////////////////


