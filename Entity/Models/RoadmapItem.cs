using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
     public  class RoadmapItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int Status { get; set; }
        public DateTime TargetEndDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RoadmapId { get; set; }
        public int ParentId { get; set; }

        public ICollection<Roadmap> Roadmap { get; set; }
       
    }
}
