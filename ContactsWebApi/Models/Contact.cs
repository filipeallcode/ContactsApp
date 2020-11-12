using System.ComponentModel.DataAnnotations;

namespace ContactsWebApi.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Name { get; set; }

        [Required]
        public string Birth { get; set; }

        [Required]
        public string Gender { get; set; }
    }
}