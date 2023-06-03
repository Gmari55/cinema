using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataacces.Entities
{
    public class Actor
    {
       public int id { get; set; }
        public string name { get; set; }
        public DateTime birthdate { get; set; }
        public DateTime? deaddate { get; set; }
        public ICollection<Film>? films { get; set; }

    }
}
