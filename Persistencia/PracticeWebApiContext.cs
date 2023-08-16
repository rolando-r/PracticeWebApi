using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class PracticeWebApiContext : DbContext
    {
        public PracticeWebApiContext(DbContextOptions<PracticeWebApiContext> options) : base(options)
        {
        }
    }
}