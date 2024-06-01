using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Services.Savings
{
    public interface ISavingReposatory
    {
        public List<Saving> GetAllSaving();

        public Saving GetSaving(int id);
    }
}
