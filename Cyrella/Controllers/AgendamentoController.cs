using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cyrella.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("{id}")]
        public ActionResult<AgendamentoManutencao> GetById(int id)
        {
            var agendamento = _cyrellaDbContext
                .AgendamentoManutencao
                .Include(a => a.ImagensAnexas)
                .FirstOrDefault(agendamento => agendamento.Id == id);

            return agendamento;
        }

        [HttpPost]
        public ActionResult Post([FromBody] AgendamentoManutencao agendamento)
        {
            try
            {
                _cyrellaDbContext.Add(agendamento);
                _cyrellaDbContext.SaveChanges();

                return Created("", agendamento);
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] AgendamentoManutencao agendamento)
        {
            try
            {
                var agendamentoUpdate = _cyrellaDbContext.Attach(agendamento);
                agendamentoUpdate.State = EntityState.Modified;

                _cyrellaDbContext.SaveChanges();
                return Ok();
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                if (id <= 0) return BadRequest();

                var agendamento = _cyrellaDbContext
                    .AgendamentoManutencao.Find(id);
                
                if (agendamento == null) return NotFound();

                var imagens = _cyrellaDbContext.ImagensAgendamentos
                    .Where(i => i.AgendamentoManutencaoId == id).ToList();

                _cyrellaDbContext.ImagensAgendamentos.RemoveRange(imagens);
                _cyrellaDbContext.AgendamentoManutencao.Remove(agendamento);

                _cyrellaDbContext.SaveChanges();

                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
