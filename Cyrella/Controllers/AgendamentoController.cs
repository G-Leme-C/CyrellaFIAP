using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cyrella.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cyrella.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        private readonly CyrellaDbContext _cyrellaDbContext;

        public AgendamentoController(CyrellaDbContext cyrellaDbContext)
        {
            this._cyrellaDbContext = cyrellaDbContext;
        }


        [HttpGet]
        public ActionResult<List<AgendamentoManutencao>> Get()
        {
            var agendamentos = _cyrellaDbContext.AgendamentoManutencao.ToList();

            return agendamentos;
        }

        public ActionResult Post([FromBody] AgendamentoManutencao agendamento)
        {
            try
            {
                _cyrellaDbContext.Add(agendamento);
                _cyrellaDbContext.SaveChanges();

//                return Created(new Uri("api/agendamento"), agendamento);
                return Created("", agendamento);
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
    }
}
