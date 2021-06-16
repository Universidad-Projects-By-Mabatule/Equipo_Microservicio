using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoAPI.Data.Entities
{
    public class EquipoEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Pais { get; set; }
        public string Entrenador { get; set; }

    }
}
