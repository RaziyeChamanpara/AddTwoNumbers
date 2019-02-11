using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HistoryDatabase
    {
        private AddTwoNumbersEntities _db = new AddTwoNumbersEntities();
        public List<History> Histories { get; set; }

        public void LoadFromDatabase()
        {
            Histories = _db.Histories.ToList();
        }

        public void SaveToDatabase(History history)
        {
            _db.Histories.Add(history);
            _db.SaveChanges();
        }
    }


}
