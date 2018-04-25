using System;
using System.Collections.Generic;

namespace PTOCore.Repositories.PTO
{
    public class PTORepository : IPTORepository
    {
        public ICollection<PTORepository> GetAllEmployeesPTOHoursByDateRange(DateTime FromDate, DateTime toDate)
        {
            // get the Data contect and read from DB
            // list all
            //return list 
            throw new NotImplementedException();
        }
    }
}