using System.ComponentModel.DataAnnotations;

namespace CreateDb.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
    }
}