using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CordiSimpleDotnet.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        [Column("name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(100, ErrorMessage = "Last name cannot exceed 100 characters.")]
        [Column("last_name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(255, ErrorMessage = "Email cannot exceed 255 characters.")]
        [Column("email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [PasswordPropertyText]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Password must be between 4 and 100 characters long.")]
        [Column("password")]
        public string Password { get; set; }

        [Column("role")]
        [Required(ErrorMessage = "Role is required.")]
        [MaxLength(100)]
        public string Role { get; set; }
    }
}
