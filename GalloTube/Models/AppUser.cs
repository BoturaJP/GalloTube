using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GalloTube.Models;

    public class AppUser
    {
        
    [Required]
    [StringLength(60)]
    public string Name { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }   

    [StringLength(200)]
    public string ProfilePicture { get; set; }
    public ICollection<VideoComment> Comments { get; set; }
    public ICollection<VideoRating> Ratings { get; set; }
}
        
    
