using ManageMoney.Application.DTOs;
using ManageMoney.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ManageMoney.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvestimentController : ControllerBase
    {
        private readonly IInvestimentService _investimentService;

        public InvestimentController(IInvestimentService investimentService)
        {
            _investimentService = investimentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvestimentDTO>>> GetInvestiments(CancellationToken cancellationToken)
        {
            var investiments = await _investimentService.GetInvestiments(cancellationToken);
            return Ok(investiments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InvestimentDTO>> GetInvestiment(Guid id, CancellationToken cancellationToken)
        {
            var investiment = await _investimentService.GetInvestiment(id, cancellationToken);
            if (investiment == null)
            {
                return NotFound();
            }
            return Ok(investiment);
        }

        [HttpPost]
        public async Task<ActionResult> AddInvestiment(InvestimentDTO investimentDTO)
        {
            await _investimentService.Add(investimentDTO);
            return CreatedAtAction(nameof(GetInvestiment), new { id = investimentDTO.Id }, investimentDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateInvestiment(Guid id, InvestimentDTO investimentDTO)
        {
            if (id != investimentDTO.Id)
            {
                return BadRequest();
            }

            await _investimentService.Update(investimentDTO);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteInvestiment(Guid id, CancellationToken cancellationToken)
        {
            await _investimentService.Delete(id, cancellationToken);
            return NoContent();
        }
    }
}
