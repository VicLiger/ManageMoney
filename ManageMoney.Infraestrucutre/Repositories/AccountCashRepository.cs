﻿using ManageMoney.Domain.Entities;
using ManageMoney.Domain.Interfaces.Repositories;
using ManageMoney.Infraestrucutre.Context;
using Microsoft.EntityFrameworkCore;

namespace ManageMoney.Infraestrucutre.Repositories
{
    public class AccountCashRepository : IAccountCashRepository
    {
        private readonly AppDbContext context;
        public AccountCashRepository(AppDbContext _context)
        {
            this.context = _context;
        }

        public async Task<IEnumerable<AccountCash>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await context.Set<AccountCash>().ToListAsync(cancellationToken);
        }

        public async Task<AccountCash> GetIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await context.Set<AccountCash>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }
        public void Create(AccountCash accountCash)
        {
            context.Add(accountCash);
        }

        public void Delete(AccountCash accountCash)
        {
            context.Remove(accountCash);
        }


        public void Update(AccountCash accountCash)
        {
            context.Update(accountCash);
        }
    }
}