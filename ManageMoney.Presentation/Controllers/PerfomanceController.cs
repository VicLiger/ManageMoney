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
    public class PerfomanceController : ControllerBase
    {
        private readonly IPerfomanceService _perfomanceService;

        public PerfomanceController(IPerfomanceService perfomanceService)
        {
            _perfomanceService = perfomanceService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerfomanceDTO>>> GetPerfomances(CancellationToken cancellationToken)
        {
            var perfomances = await _perfomanceService.GetPerfomances(cancellationToken);
            return Ok(perfomances);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PerfomanceDTO>> GetPerfomance(Guid id, CancellationToken cancellationToken)
        {
            var perfomance = await _perfomanceService.GetPerfomance(id, cancellationToken);
            if (perfomance == null)
            {
                return NotFound();
            }
            return Ok(perfomance);
        }

        [HttpPost]
        public async Task<ActionResult> AddPerfomance(PerfomanceDTO perfomanceDTO)
        {
            await _perfomanceService.Add(perfomanceDTO);
            return CreatedAtAction(nameof(GetPerfomance), new { id = perfomanceDTO.Id }, perfomanceDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePerfomance(Guid id, PerfomanceDTO perfomanceDTO)
        {
            if (id != perfomanceDTO.Id)
            {
                return BadRequest();
            }

            await _perfomanceService.Update(perfomanceDTO);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePerfomance(Guid id, CancellationToken cancellationToken)
        {
            await _perfomanceService.Delete(id, cancellationToken);
            return NoContent();
        }
    }
}
