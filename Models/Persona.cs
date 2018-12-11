using System;
using System.ComponentModel.DataAnnotations;

namespace RazorApp.Models
{
    public class Persona
    {
        public int ID { get; set; }
        public int NumeroDocumento { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
    }
}