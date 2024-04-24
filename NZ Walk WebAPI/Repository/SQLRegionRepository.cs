using Microsoft.EntityFrameworkCore;
using NZ_Walk_WebAPI.Data;
using NZ_Walk_WebAPI.Models.Domain_Models;

namespace NZ_Walk_WebAPI.Repository
{
    public class SQLRegionRepository : IRegionRepository
    {
        private readonly NZClassDBContext dBContext;

        public SQLRegionRepository(NZClassDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public async Task<Region> CreateAsync(Region region)
        {
            await dBContext.Regions.AddAsync(region);
            await dBContext.SaveChangesAsync();
            return region;
        }

        public async Task<Region?> DeleteAsync(Guid id)
        {
            var existingRegion = await dBContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
            if (existingRegion == null)
            {
                return null;
            }
            dBContext.Regions.Remove(existingRegion);
            await dBContext.SaveChangesAsync();
            return existingRegion;

        }

        public async Task<List<Region>> GetAllAsync()
        {
            return await dBContext.Regions.ToListAsync();
        }

        public async Task<Region?> GetByIdAsync(Guid id)
        {
            return await dBContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Region?> UpdateAsync(Guid id, Region region)
        {
            var updatingRegion = await dBContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
            if (updatingRegion == null) { return null; }

            updatingRegion.Code = region.Code;
            updatingRegion.Name = region.Name;
            updatingRegion.RegionImageUrl = region.RegionImageUrl;
            await dBContext.SaveChangesAsync();
            return updatingRegion;

        }
    }
}
