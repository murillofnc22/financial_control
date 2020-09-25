using System.ComponentModel.DataAnnotations;

namespace Financial.Entities.Entities
{
    public class Base
    {
        [Display(Name = "Identifier")]
        public int Id { get; set; }
    }
}
