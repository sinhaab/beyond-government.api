using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondGovernment.Data
{
    public class DbContextFactory : IDbContextFactory
    {
        public DbContextFactory()
        {

        }

        public BeyondGovernmentEntities GetDbContext() 
        {
            return new BeyondGovernmentEntities();
        }
    }
}
