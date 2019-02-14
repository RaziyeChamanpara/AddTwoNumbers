using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HistoryRepository: IHistoryRepository
    {
        AddTwoNumbersEntities Db = new AddTwoNumbersEntities();

        public List<History> GetAll()
        {
            return Db.Histories.ToList();
        }

        public void Save(History history)
        {
            Db.Histories.Add(history);
            Db.SaveChanges();
        }
    }
}
