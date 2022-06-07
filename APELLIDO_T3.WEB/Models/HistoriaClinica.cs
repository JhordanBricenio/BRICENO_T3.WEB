using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APELLIDO_T3.WEB.Models
{
    [Table("HistoriaClinica")]
    [Index(nameof(Id), IsUnique = true)]
    public class HistoriaClinica
    {

        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [DisplayName("Fecha de Registro")]
        [Required(ErrorMessage = "El campo es requerido")]
        public DateTime FechaRegistro { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public string NombreMascota { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public DateTime FechaNacimiento { get; set; }

        //[Required(ErrorMessage = "El campo es requerido")]
        public string Sexo { get; set; }

        public string Especie { get; set; }

        public string Raza { get; set; }

        public decimal Tamaño { get; set; }
        
        public string DatosParticulares { get; set; }


        [DisplayName("Nombre del Dueño")]
        [Required(ErrorMessage = "El campo Email es requerido")]
        public string NombreDueno { get; set; }

        [DisplayName("Direccion del Dueño")]

        [Required(ErrorMessage = "El campo DireccionDueno es requerido")]
        public string DireccionDueno { get; set; }


        [Required(ErrorMessage = "El campo Telefono es requerido")]
        public string Telefono { get; set; }


        
        [EmailAddress]
        public string Email { get; set; }


    }
}
