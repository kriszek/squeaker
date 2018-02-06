using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeaker.DataAccess
{
    public class DbInitiliazer : DropCreateDatabaseIfModelChanges<SqueakerContext>
    {
        protected override void Seed(SqueakerContext context)
        {

        }
    }
}
