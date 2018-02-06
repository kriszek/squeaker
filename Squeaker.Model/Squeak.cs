using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeaker.Model
{
    public class Squeak
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTimeOffset CreationDate { get; set; }

        public virtual ICollection<SqueakComment> SqueakComments { get; set; }
    }
}
