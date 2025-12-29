using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace EmployeeManagementAPI.Data
{
    // ApplicationDbContext should inherit from DbContext, not DbConnection.
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
