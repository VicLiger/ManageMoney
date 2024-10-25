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
    public class ConsumptionController : ControllerBase
    {
        private readonly IConsumptionService _consumptionService;

        public ConsumptionController(IConsumptionService consumptionService)
        {
            _consumptionService = consumptionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsumptionDTO>>> GetConsumptions(CancellationToken cancellationToken)
        {
            var consumptions = await _consumptionService.GetConsumptions(cancellationToken);
            return Ok(consumptions);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConsumptionDTO>> GetConsumption(Guid id, CancellationToken cancellationToken)
        {
            var consumption = await _consumptionService.GetConsumption(id, cancellationToken);
            if (consumption == null)
            {
                return NotFound();
            }
            return Ok(consumption);
        }

        [HttpPost]
        public async Task<ActionResult> AddConsumption(ConsumptionDTO consumptionDTO)
        {
            await _consumptionService.Add(consumptionDTO);
            return CreatedAtAction(nameof(GetConsumption), new { id = consumptionDTO.Id }, consumptionDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateConsumption(Guid id, ConsumptionDTO consumptionDTO)
        {
            if (id != consumptionDTO.Id)
            {
                return BadRequest();
            }

            await _consumptionService.Update(consumptionDTO);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteConsumption(Guid id, CancellationToken cancellationToken)
        {
            await _consumptionService.Delete(id, cancellationToken);
            return NoContent();
        }
    }
}
