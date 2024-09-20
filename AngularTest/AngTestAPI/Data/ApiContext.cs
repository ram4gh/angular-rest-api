using Microsoft.EntityFrameworkCore;
using AngTestAPI.Models;

namespace AngTestAPI.Data
{
    //BAsic in memory DB
    public class ApiContext : DbContext
    {
        public DbSet<API_Test> Api_Tests { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) 
            :base(options)
        { 
        
        }
    }
}
