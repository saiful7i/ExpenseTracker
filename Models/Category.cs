using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Category
    {
        [key]
        public int categoryId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; } = "Expense";

        [NotMapped]
        public string? TitleWithIcon
        {
            get
            {
                return this.Icon + " " + this.Title;
            }
        }
    }
}
