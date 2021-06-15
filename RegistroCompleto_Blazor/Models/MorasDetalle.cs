using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCompleto_Blazor.Models
{
    public class MorasDetalle
    {
        [Key]
        public int MorasDetalleId { get; set; }

        public int MoraId { get; set; }

        public int PrestamoId { get; set; }

        public decimal Valor { get; set; }

        public MorasDetalle(int moraId, int prestamoId, decimal valor)
        {
            MoraId = moraId;
            PrestamoId = prestamoId;
            Valor = valor;
        }

        public MorasDetalle()
        {
        }
    }
}
