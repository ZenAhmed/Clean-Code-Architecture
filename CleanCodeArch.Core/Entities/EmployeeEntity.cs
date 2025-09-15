using System.ComponentModel.DataAnnotations.Schema;

namespace CleanCodeArch.Domian.Entities
{
    public class EmployeeEntity
    {
        [Column("employee_id")]
        public Guid Id { get; set; }

        [Column("employee_name")]
        public required string Name { get; set; }

        [Column("employee_email")]
        public required string Email { get; set; }

        [Column("employee_phone")]
        public string Phone { get; set; } = null!;
    }
}
