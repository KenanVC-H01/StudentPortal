using Microsoft.EntityFrameworkCore;

namespace StudentPortal.Web.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
        { 
        
        }

    }
}
