using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IHistoryDatabase
    {
        List<History> GetAll();
        void SaveToDatabase(History history);
    }
}
