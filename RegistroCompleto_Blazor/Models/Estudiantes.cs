using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistroCompleto_Blazor.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteID { get; set; }
        
        [Required(ErrorMessage ="Es Obligatorio introducir el nombre")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Es Obligatorio introducir el apellido")]
        public string Apellidos { get; set; }

        [Range(minimum: 1, maximum: 100, ErrorMessage = "Seleccione el semestre")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Es Obligatorio introducir la carrera")]
        public string Carrera { get; set; }


        [Range (minimum:1, maximum:13 , ErrorMessage = "Seleccione el semestre")]
        public int Semestre { get; set; }


        public Estudiantes()
        {
        }
    }
}
