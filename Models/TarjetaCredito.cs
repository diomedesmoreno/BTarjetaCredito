using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTarjetasCreditos.Models
{
    public class TarjetaCredito
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre del titular es requerido")]
        public String Titular { get; set; }
        [Required(ErrorMessage = "Número de tarjeta es requerida")]
        public String NumeroTarjeta { get; set; }
        [Required(ErrorMessage = "Fecha de expiración es requerido")]
        public String FechaExpiracion { get; set; }
        [Required(ErrorMessage = "CVV es requerida")]
        public int CVV { get; set; }

    }
}
