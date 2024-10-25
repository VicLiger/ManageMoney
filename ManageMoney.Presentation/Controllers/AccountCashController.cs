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
    public class AccountCashController : ControllerBase
    {
        private readonly IAccountCashService _accountCashService;

        public AccountCashController(IAccountCashService accountCashService)
        {
            _accountCashService = accountCashService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountCashDTO>>> GetAccountsCash(CancellationToken cancellationToken)
        {
            var accounts = await _accountCashService.GetAccountsCash(cancellationToken);
            return Ok(accounts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AccountCashDTO>> GetAccountCashById(Guid id, CancellationToken cancellationToken)
        {
            var account = await _accountCashService.GetAccountsCashId(id, cancellationToken);
            if (account == null)
            {
                return NotFound();
            }
            return Ok(account);
        }

        [HttpPost]
        public async Task<ActionResult> AddAccountCash(AccountCashDTO accountCashDTO)
        {
            await _accountCashService.Add(accountCashDTO);
            return CreatedAtAction(nameof(GetAccountCashById), new { id = accountCashDTO.Id }, accountCashDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAccountCash(Guid id, AccountCashDTO accountCashDTO)
        {
            if (id != accountCashDTO.Id)
            {
                return BadRequest();
            }

            await _accountCashService.Update(accountCashDTO);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAccountCash(Guid id, CancellationToken cancellationToken)
        {
            await _accountCashService.Delete(id, cancellationToken);
            return NoContent();
        }
    }
}
