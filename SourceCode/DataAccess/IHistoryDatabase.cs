using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IHistoryRepository
    {
        List<History> GetAll();
        void Save(History history);
    }
}
