using System.ComponentModel.DataAnnotations;

namespace _2080600534_dotruonghoangnhat.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required,StringLength(255)]
        public string Name { get; set; }
    }
}