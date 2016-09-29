using SavingVariables.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingVariables
{
    public class Constants
    {

        public VariablesRepository repo { get; set; }

        public Constants()
        {
            repo = new VariablesRepository();
        }

        public Constants(VariablesRepository _repo)
        {
            repo = _repo;
        }

        public void AddConstantsToRepository(string key, int val)
        {
            repo.AddVariableAndValue(key, val);
        }

        public bool CheckForExistingId(string id)
        {
            return repo.VariableExists(id);
        }

        public void AddVariableToRepository(string key, int value)
        {
            if (!CheckForExistingId(key))
            {
                repo.AddVariableAndValue(key, value);
            }
            else
            {
                throw new ArgumentException("Already stored variable.");
            }
        }

        public int GetConstant(string key)
        {
            if (CheckForExistingId(key))
            {
                return repo.GetVarValueByVarName(key);
            }
            throw new ArgumentException($"Constant '{key}' has not been stored yet");
        }

    }
}
