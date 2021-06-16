using EquipoAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoAPI.Data.Repository
{
    interface ILibraryRepository
    {
        public Task<IEnumerable<EquipoEntity>> GetEquipos(string orderBy);
        public Task<EquipoEntity> GetEquipo(int equipoId);
        public void CreateEquipo(EquipoEntity equipoModel);
        public void DeleteEquipo(int equipoId);
        Task<bool> SaveChangesAsync();

    }
}
