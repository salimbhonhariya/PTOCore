using System;
using System.Collections.Generic;

namespace PTOCore.Repositories.PTO
{
    public interface IPTORepository
    {
       ICollection<PTORepository> GetAllEmployeesPTOHoursByDateRange(DateTime FromDate, DateTime toDate);
    }
}