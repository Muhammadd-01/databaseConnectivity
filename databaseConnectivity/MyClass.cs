using Microsoft.EntityFrameworkCore;

namespace datbase_connectivity
{
    public class Myclass : DbContext
    {
        public Myclass(DbContextOptions<Myclass> options) : base(options)
        {

        }
    }
}
