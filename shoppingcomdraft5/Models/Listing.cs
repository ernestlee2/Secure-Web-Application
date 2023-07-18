using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shoppingcomdraft5.Models
{
    public class Listing
    {
        public int ListingID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string ListingName { get; set; } = string.Empty;

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Listing Date")]
        [DataType(DataType.Date)]
        public DateTime ListingDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Category { get; set; } = string.Empty;

        [Range(1, 10000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[0-5]+[*]$")]
        [StringLength(2)]
        [Required]
        public string Condition { get; set; } = string.Empty;
    }
}
