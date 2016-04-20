using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YOLO.Models
{
    public class People
    {
        [Key]
        public int PeopleId { get; set; }
        public string Name { get; set; }
        public int LocationsId { get; set; }
        public virtual Locations Locations { get; set; }
        public int ExperiencesId { get; set; }
        public virtual Experiences Experiences { get; set; }
        
    }
}
