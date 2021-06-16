using EquipoAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoAPI.Data.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        private List<EquipoEntity> chocolates = new List<EquipoEntity>
        {
           new EquipoEntity(){ Id = 1, Nombre= "Manjar de Oro", Cantidad = "Sky", Type = "Blanco", Shape = "Barra", Price= 8.4m, Image="https://s1.eestatic.com/2018/11/07/actualidad/actualidad_351478872_104884997_1706x960.jpg" },
           new EquipoEntity(){ Id = 2, Nombre= "Para Ti", Cantidad = "Snitch", Type = "Negro", Shape = "Bombon", Price= 15.5m,  Image= "https://www.ngenespanol.com/wp-content/uploads/2018/08/Los-chocolates-m%C3%A1s-ricos-del-mundo.jpg" },
           new EquipoEntity(){ Id = 3, Nombre= "Baure",Name = "Sunnt", Type = "Con leche", Shape = "Relleno",Price= 3m, Image= "https://dam.ngenespanol.com/wp-content/uploads/2019/08/chocolate.jpg" },
        };



        public EquipoEntity CreateEquipo(EquipoEntity equipoModel)
        {
            throw new NotImplementedException();
        }

        public EquipoEntity DeleteEquipo(int equipoId)
        {
            throw new NotImplementedException();
        }

        public EquipoEntity GetEquipo(int equipoId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EquipoEntity> GetEquipos(string orderBy)
        {
            throw new NotImplementedException();
        }
    }
}
