using Microsoft.EntityFrameworkCore;
namespace appsettings.database

{
    public class Connect : DbContext {
        public Connect(DbConxtexOptions<Connect> options) : base(options){}

    } 
}