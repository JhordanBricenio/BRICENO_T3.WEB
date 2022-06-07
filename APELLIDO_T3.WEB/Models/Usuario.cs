using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APELLIDO_T3.WEB.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Username es requerido")]
        [StringLength(8, ErrorMessage = "la longitud debe estar entre 8 y 3 caracteres.", MinimumLength = 3)]
        public string Username { get; set; }


        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [MaxLength(45, ErrorMessage = "El campo Nombre no puede tener mas de 45 caracteres")]
        [MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]
        public String Nombre { get; set; }



        [Required(ErrorMessage = "El campo Password es requerido")]
        [MaxLength(50, ErrorMessage = "El campo Password no puede tener mas de 50 caracteres")]
        [MinLength(5, ErrorMessage = "El Password debe tener al menos 5 caracteres")]
        public string Password { get; set; }
    }
}
