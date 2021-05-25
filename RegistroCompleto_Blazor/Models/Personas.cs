using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroCompleto_Blazor.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public decimal Balance { get; set; }

        [ForeignKey("PersonaId")]
        public virtual List<Prestamos> Prestamos { get; set; }
    }
}
