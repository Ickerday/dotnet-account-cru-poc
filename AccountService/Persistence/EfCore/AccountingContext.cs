﻿using AccountService.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccountService.Persistence.EfCore
{
    public class AccountingContext : DbContext, IDbInfrastructure<DbSet<Account>>
    {
        public DbSet<Account> Accounts { get; set; }

        public AccountingContext(DbContextOptions options) : base(options)
        {
        }
    }
}