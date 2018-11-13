using AccountService.Core.Entities;
using AccountService.Core.Exceptions;
using AccountService.Persistence.EfCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace AccountService.Application.Queries
{
    public class EfAccountQueries : IAccountQueries
    {
        private readonly AccountingContext _context;
        private readonly ILogger<EfAccountQueries> _logger;

        public EfAccountQueries(AccountingContext context, ILogger<EfAccountQueries> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Account> GetAll()
        {
            _logger.LogInformation("Getting all Accounts");
            return _context.Accounts
                .ToArray();
        }

        public Account GetBy(ulong id)
        {
            _logger.LogInformation($"Searching for Account with ID {id}");
            var result = _context.Accounts
                .Find(id);

            if (result != null)
                throw new AccountNotFoundException($"No Account with ID {id} found");

            return result;
        }
    }
}