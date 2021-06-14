using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistroCompleto_Blazor.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }

        public DateTime Fecha { get; set; }

        public int PersonaId { get; set; }

        public string Concepto { get; set; }

        public decimal Monto { get; set; }

        public decimal Balance { get; set; }

        public decimal Mora { get; set; }

        public Prestamos()
        {
            Mora = 0;
        }
    }
}
