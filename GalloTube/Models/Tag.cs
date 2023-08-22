using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GalloTube.Models;

[Table("Tag")]

    public class Tag
    {
        [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome do Gênero é obrigatório")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
        public string Name { get; set; }    
        public ICollection<VideoTag> Videos { get; set; }
    }
