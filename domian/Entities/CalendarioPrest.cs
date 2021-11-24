using domian.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace domian.Entities
{
   public class CalendarioPrest
    {
        public int Id { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Principal { get; set; }
        public decimal PrincipalPagado { get; set; }
        public decimal Interes { get; set; }
        public decimal InteresPagado { get; set; }
        public decimal Cuota { get; set; }
        public decimal CuotaPagado { get; set; }
        public Estado Estado { get; set; }
    }
}
