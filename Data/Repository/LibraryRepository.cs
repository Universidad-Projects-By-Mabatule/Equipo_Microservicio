using EquipoAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoAPI.Data.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        private EquipoDbContext _dbContext;
        public LibraryRepository(EquipoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateEquipo(EquipoEntity equipoModel)
        {
            _dbContext.Equipos.Add(equipoModel);
        }

        public async Task<EquipoEntity> GetEquipo(int equipoId)
        {
            IQueryable<EquipoEntity> query = _dbContext.Equipos;
            query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(t => t.Id == equipoId);
        }


        public async Task<IEnumerable<EquipoEntity>> GetEquipos(string orderBy)
        {
            IQueryable<EquipoEntity> query = _dbContext.Equipos;
            query = query.AsNoTracking();
            switch (orderBy.ToLower())
            {
                case "name":
                    query = query.OrderBy(t => t.Nombre);
                    break;
                case "pais":
                    query = query.OrderBy(t => t.Pais);
                    break;
                case "cantidad":
                    query = query.OrderBy(t => t.Cantidad);
                    break;
                case "entrenador":
                    query = query.OrderBy(t => t.Entrenador);
                    break;
                default:
                    query = query.OrderBy(t => t.Id);
                    break;
            }

            return await query.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                var res = await _dbContext.SaveChangesAsync();
                return res > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //*******


        public void DeleteEquipo(int equipoId)
        {
            throw new NotImplementedException();
        }
    }
}
