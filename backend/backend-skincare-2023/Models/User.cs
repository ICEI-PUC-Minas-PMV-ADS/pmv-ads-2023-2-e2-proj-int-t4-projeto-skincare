
using static System.Net.Mime.MediaTypeNames;

namespace backend_skincare_2023.Models
{
    [Index(nameof(Email), IsUnique = true)] //Nao vai permitir emails duplicados
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Name field is required")]
        [StringLength(40)]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last name field is required")]        
        [StringLength(40)]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email field is required")]
        [StringLength(25)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Birth date is required")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string PasswordKey { get; set; }


        // Método para criar um hash seguro da senha usando BCrypt
        public void SetPassword(string password)
        {
            PasswordKey = BCrypt.Net.BCrypt.HashPassword(password);

        }

        // Método para verificar se a senha fornecida corresponde ao hash
        public bool VerifyPassword(string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, PasswordKey);
        }

    }
}

