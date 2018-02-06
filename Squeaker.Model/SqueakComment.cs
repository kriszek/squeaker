using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeaker.Model
{
    public class SqueakComment
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public int SqueakID { get; set; }
        public DateTimeOffset CreationDate { get; set; }

        public virtual Squeak Squeak { get; set; }
    }
}
