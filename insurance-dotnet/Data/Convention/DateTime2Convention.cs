using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Conventionn
{
    public class DateTime2Conventionn: Convention
    {

        public DateTime2Conventionn()
        {
            this.Properties<DateTime>().Configure(e => e.HasColumnType ("datetime2"));
        }
    }
}
