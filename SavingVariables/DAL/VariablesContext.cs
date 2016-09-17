using SavingVariables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables.DAL
{
    public class VariablesContext : DbContext
    {
        public virtual DbSet<Variables> Variable { get; set; }
    }
}
