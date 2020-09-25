using System.ComponentModel.DataAnnotations;

namespace Financial.Entities.Entities
{
    public class Base
    {
        [Display(Name = "Codigo")]
        public int Id { get; set; }
    }
}
