using Microsoft.EntityFrameworkCore;

namespace SubiektGTModels.DB
{
    public class MssqlConnect : DbContext
    {
        public MssqlConnect(DbContextOptions options) : base(options)
        {
        }
    }
}
