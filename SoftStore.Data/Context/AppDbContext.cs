using Microsoft.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore.SqlServer; 

namespace SoftStore.Data; 

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    
}