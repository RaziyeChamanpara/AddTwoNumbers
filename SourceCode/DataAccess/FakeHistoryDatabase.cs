using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FakeHistoryRepository : IHistoryRepository
    {
        public List<History> GetAll()
        {
            return new List<History>()
            {
                new History(){ Number1=1, Number2=2, Sum=3},
                new History(){ Number1=4, Number2=2, Sum=6},
                new History(){ Number1=10, Number2=2, Sum=12},
            };

        }

        public void Save(History history)
        {
        }
    }
}
