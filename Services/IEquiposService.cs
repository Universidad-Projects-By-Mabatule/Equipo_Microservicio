using EquipoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoAPI.Services
{
    public interface IEquiposService
    {
        public Task<IEnumerable<EquipoModel>> GetEquipoModels(string orderBy);
        public Task<EquipoModel> GetEquipo(int equipoId);
        public void CreateEquipo(EquipoModel equipoModel);
        public void DeleteEquipo(int equipoId);

    }
}
