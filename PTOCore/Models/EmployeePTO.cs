using PTOCore.Models;
using System.ComponentModel.DataAnnotations;

namespace PTOCore.Data
{
    public class EmployeePTO : AuditedEntity
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
    }
}