using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataacces.Entities
{
    public class Seans
    {
        public int Id { get; set; }
        public int filmid { get; set; }
        public Film? film { get; set; }
        public DateTime timestart { get; set; }
        public DateTime timeend { get; set; }
    }
}
