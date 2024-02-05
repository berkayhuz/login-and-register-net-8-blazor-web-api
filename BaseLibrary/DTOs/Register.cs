using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.DTOs
{
    public class Register : AccountBase
    {
        [MinLength(5)]
        [MaxLength(50)]
        [Required]
        public string? Fullname {  get; set; }

        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        [Required]
        public string? ConfirmPassword {  get; set; }
    }
}
