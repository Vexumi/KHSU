using System.ComponentModel.DataAnnotations;

namespace Parser.Model
{
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}
