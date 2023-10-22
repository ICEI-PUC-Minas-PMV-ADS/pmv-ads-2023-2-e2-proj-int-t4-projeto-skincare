
using static System.Net.Mime.MediaTypeNames;

namespace backend_skincare_2023.Models
{
    [Index(nameof(Email), IsUnique = true)] //Nao vai permitir emails duplicados
    public class User
    {
        [Key]

        // Propriedade para exibição formatada da data de nascimento
        public string FormattedBirthDate => BirthDate.ToShortDateString();
        public int UserId { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome.")]
        [StringLength(40)]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o sobrenome")]        
        [StringLength(40)]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o email")]
        [StringLength(25)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Obrigatório informar a data de nascimento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Obrigatório informar uma senha")]
        [DataType(DataType.Password)]
        public string PasswordKey { get; set; }

        [Required(ErrorMessage = "Obrigatório informar um tipo de usuário")]
        public Perfil Perfil { get; set; }

        
        public ICollection<Routine> Routines { get; set; } //Lista todas as rotinas de um determinado usuario na query

    }
    public enum Perfil
    {
        Admin,
        User
    }
}

