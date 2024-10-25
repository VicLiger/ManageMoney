using ManageMoney.Application.DTOs;
using ManageMoney.Application.Interfaces;
using ManageMoney.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ManageMoney.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinancialObjectiveController : ControllerBase
    {
        private readonly IFinancialObjectiveService _financialObjectiveService;

        public FinancialObjectiveController(IFinancialObjectiveService financialObjectiveService)
        {
            _financialObjectiveService = financialObjectiveService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinancialObjectiveDTO>>> GetFinancialObjectives(CancellationToken cancellationToken)
        {
            var objectives = await _financialObjectiveService.GetFinancialObjectives(cancellationToken);
            return Ok(objectives);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FinancialObjectiveDTO>> GetFinancialObjective(Guid id, CancellationToken cancellationToken)
        {
            var objective = await _financialObjectiveService.GetFinancialObjective(id, cancellationToken);
            if (objective == null)
            {
                return NotFound();
            }
            return Ok(objective);
        }

        [HttpPost]
        public async Task<ActionResult> AddFinancialObjective(FinancialObjectiveDTO financialObjectiveDTO)
        {
            await _financialObjectiveService.Add(financialObjectiveDTO);
            return CreatedAtAction(nameof(GetFinancialObjective), new { id = financialObjectiveDTO.Id }, financialObjectiveDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateFinancialObjective(Guid id, FinancialObjectiveDTO financialObjectiveDTO)
        {
            if (id != financialObjectiveDTO.Id)
            {
                return BadRequest();
            }

            await _financialObjectiveService.Update(financialObjectiveDTO);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFinancialObjective(Guid id, CancellationToken cancellationToken)
        {
            await _financialObjectiveService.Delete(id, cancellationToken);
            return NoContent();
        }
    }
}
