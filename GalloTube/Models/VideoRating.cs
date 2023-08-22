using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloTube.Models;
[Table("VideoRating")]
public class MovieRating
{
    [Key, Column(Order = 1)]
    public int MovieId { get; set; }
    [ForeignKey("MovieId")]
    public Video Video { get; set; }

    [Key, Column(Order = 2)]
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public AppUser User { get; set; }

    [Required]
    public byte RatingValue { get; set; }

    [Required]
    public DateTime RatingDate { get; set; }
}
