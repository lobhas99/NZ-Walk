using Microsoft.EntityFrameworkCore;
using NZ_Walk_WebAPI.Models.Domain;

namespace NZ_Walk_WebAPI.Data
{
    public class NZClassDBContext : DbContext
    {
        public NZClassDBContext(DbContextOptions<NZClassDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        public DbSet<Image> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id=Guid.Parse("5f91622c-132e-4497-9049-f190ffcefedd"),
                    Name="Easy"
                },
                new Difficulty()
                {
                    Id=Guid.Parse("93ca4a3f-3445-4729-bfaf-aa6451067f12"),
                    Name="Medium"
                },
                new Difficulty()
                {
                    Id=Guid.Parse("12bdbc78-aa72-401a-bdfb-5f6abeb86ae9"),
                    Name="Hard"
                }
            };
            modelBuilder.Entity<Difficulty>().HasData(difficulties);
            var regions = new List<Region>()
            {
                new Region()
                {
                    Id=Guid.Parse("594e53f8-0311-472e-8ae2-d13ca69eab1c"),
                    Name="Auckland",
                    Code="AKL",
                    RegionImageUrl="Some-image.jpg"
                },
                new Region
                {
                    Id = Guid.Parse("f7248fc3-2585-4efb-8d1d-1c555f4087f6"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("14ceba71-4b51-4777-9b17-46602cf66153"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                }
            };
            modelBuilder.Entity<Region>().HasData(regions);

        }
    }
}
