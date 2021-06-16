using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoAPI.Models
{
    public class EquipoModel
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Pais { get; set; }
        public string Entrenador { get; set; }
    }
}
