using SavingVariables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;

namespace SavingVariables.DAL
{
    public class VariablesContext : DbContext
    {
        public virtual DbSet<Variable> Variables { get; set; }
    }
}
