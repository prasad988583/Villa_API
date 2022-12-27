using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Villa_API.Model;

namespace Villa_API.Data
{
    public class Applicaitondbcontext : DbContext
    {
        public Applicaitondbcontext(DbContextOptions<Applicaitondbcontext> options)
            : base(options)
        {

        }
        public DbSet<Villa_DTO> Villas { get; set; }
        public DbSet<VillaNumber> VillasNumbers { get; set; }
        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa_DTO>().HasData(

                new Villa_DTO
                {
                    Id = 1,
                    Name = "Conga",
                    Description = "Excelence"
                },
                 new Villa_DTO
                 {
                     Id = 2,
                     Name = "Apttus",
                     Description = "Super"
                 },
                  new Villa_DTO
                  {
                      Id = 3,
                      Name = "Prasad",
                      Description = "Ok"


                  },
                   new Villa_DTO
                   {
                       Id = 4,
                       Name = "Sekhar",
                       Description = "NA"
                   }
                );

        }
    }
}
