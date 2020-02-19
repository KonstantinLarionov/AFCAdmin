using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCAdmin.Model
{
    public enum TypeProject
    { 
        DEVELOP,
        SEO,
        MAINTENANCE
    }
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer Customer { get; set; }
        public List<Worker> Workers { get; set; } 
        public List<Work> Works { get; set; }
        public DateTime DateTake { get; set; }
        public DateTime DateRelease { get; set; }
        public List<Operation> Operations { get; set; }
    }
}
