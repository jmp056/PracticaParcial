using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaParcial.Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        [Required(ErrorMessage ="El nombre no puede estar vacio!...")]
        public string Nombres { get; set; }
        public DateTime Fecha { get; set; }
        [Required]
        [Phone(ErrorMessage ="Debe ingresar un numero de telefono valido!...")]
        public string Telefono { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo electronico valido!...")]
        public string Correo { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 999999999999, ErrorMessage ="El capital debe estar comprendido entre 1 y 999,999,999,999")]
        public float Capital { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 999999, ErrorMessage = "La cantidad de semanas deben estar comprendidas entre 1 y 999,999")]
        public int Semanas { get; set; }
        public float MontoCuotas { get; set; }

        public Prestamos()
        {
            PrestamoId = 0;
            Nombres = string.Empty;
            Fecha = DateTime.Now;
            Telefono = string.Empty;
            Correo = string.Empty;
            Capital = 0;
            Semanas = 0;
            MontoCuotas = 0;
        }
    }  
}
