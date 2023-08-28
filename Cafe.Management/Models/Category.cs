using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cafe.Management.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("Display Name")]
        [Range(1,100, ErrorMessage="The dispaly order must be 1 to 100")]
        public int DisplayOrder { get; set; }
    }
}
