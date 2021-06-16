using EquipoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoAPI.Services
{
    public class EquipoService : IEquiposService
    {
        public void CreateEquipo(EquipoModel equipoModel)
        {
            throw new NotImplementedException();
        }

        public void DeleteEquipo(int equipoId)
        {
            throw new NotImplementedException();
        }

        public Task<EquipoModel> GetEquipo(int equipoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EquipoModel>> GetEquipoModels(string orderBy)
        {
            throw new NotImplementedException();
        }
    }
}
