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
        public string Nombres { get; set; }
        public DateTime Fecha { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public float Capital { get; set; }
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
