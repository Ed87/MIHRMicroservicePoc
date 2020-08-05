using EmployeesAPIService.Common;
using EmployeesAPIService.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeesAPIService.Data
{
    public class HRMSContext :DbContext
    {
        public HRMSContext(DbContextOptions<HRMSContext> options)
             : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.RemovePluralizingTableNameConvention();
        }

        public DbSet<Employee> Employee { get; set; }
    }

}
