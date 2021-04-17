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
    public class EmpreendimentoController : ControllerBase
    {
        private readonly CyrellaDbContext _cyrellaDbContext;

        public EmpreendimentoController(CyrellaDbContext cyrellaDbContext)
        {
            this._cyrellaDbContext = cyrellaDbContext;
        }


        [HttpGet("{id}")]
        public ActionResult<Empreendimento> GetById(int id)
        {
            if (id <= 0) return BadRequest();

            var empreendimento = _cyrellaDbContext.Empreendimentos
                .Include(e => e.Afetacoes)
                .Include(e => e.FasesObra)
                .Include(e => e.Personalizacao)
                .FirstOrDefault(e => e.Id == id);

            if (empreendimento == null) return NotFound();

            return empreendimento;
        } 
    }
}
