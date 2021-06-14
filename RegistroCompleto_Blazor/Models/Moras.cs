using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCompleto_Blazor.Models
{
    public class Moras
    {
        public int MoraId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
    }
}
