using Microsoft.EntityFrameworkCore;
namespace MvcMovie.database

{
    public class Connect : DbContext {
        public Connect(DbContextOptions<Connect> options) : base(options){}

    } 
}