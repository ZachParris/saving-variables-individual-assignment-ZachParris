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

        public void AddConstantsToRepository(char key, int val)
        {
            repo.AddVariableAndValue(key, val);
        }

        public bool CheckForExistingId(char id)
        {
            return repo.VariableExists(id);
        }

        public void AddVariableToRepository(char key, int value)
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

        public int GetConstant(char key)
        {
            if (CheckForExistingId(key))
            {
                return repo.GetVarValueByVarName(key);
            }
            throw new ArgumentException($"Constant '{key}' has not been stored yet");
        }

    }
}
