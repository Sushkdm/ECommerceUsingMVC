using Microsoft.EntityFrameworkCore;

namespace EcommerceWebsideUsingMVC.Models
{
    public class myContext: DbContext
    {
        public myContext(DbContextOptions<myContext> options) : base(options) 
        { 

        }       
    }
}
