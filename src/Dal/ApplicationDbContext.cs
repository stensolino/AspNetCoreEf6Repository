using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=AspNetCoreEf6Repository;Integrated Security=True; MultipleActiveResultSets=True") { }
    }
}
