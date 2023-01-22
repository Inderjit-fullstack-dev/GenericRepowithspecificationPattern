using System.ComponentModel.DataAnnotations;

namespace GenericRepositoryWithSpecificationExample.Core.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
