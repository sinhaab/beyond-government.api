using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondGovernment.Data
{
   public  interface IDbContextFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        BeyondGovernmentEntities GetDbContext();
    }
}
