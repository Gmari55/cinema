using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataacces.Entities
{

    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Duration { get; set; }
        public string Description { get; set; }
        public int ActorIds { get; set; }
        public Actor? Actors { get; set; }
       
    }

}
