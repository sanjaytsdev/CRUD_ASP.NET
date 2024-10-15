
using Microsoft.EntityFrameworkCore;
using restapi.Entities;

namespace restapi.Repository
{
    public class StudentRepo : DbContext {
        public StudentRepo(DbContextOptions<StudentRepo> options) : base(options) {
            
        }

        public DbSet<StudentEntity> Students { get; set; }
    }
}