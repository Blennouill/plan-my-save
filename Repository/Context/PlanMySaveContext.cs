using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlanMySave.Model;

namespace PlanMySave.Repository
{
    public class PlanMySaveContext : DbContext
    {
        public PlanMySaveContext(DbContextOptions<PlanMySaveContext> options) : base(options) { }

        public DbSet<Revenu> Revenus;
        public DbSet<Expense> Expenses;
    }
}
