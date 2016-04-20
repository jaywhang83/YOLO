using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YOLO.Models
{
    public class Experiences
    {
        [Key]
        public int ExperinceId { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public virtual Locations Locations { get; set; }
        public virtual ICollection<Person> People { get; set; } 
    }
}
