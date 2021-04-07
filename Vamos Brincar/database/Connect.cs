using Microsoft.EntityFrameworkCore;
namespace appsettings.database

{
    public class Connect : DbContext {
        public Connect(DbContextOptions<Connect> options) : base(options){}

    } 
}