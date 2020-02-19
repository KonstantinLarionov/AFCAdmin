using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCAdmin.Model
{
    public enum TypeWork 
    {
        TODO, INWORK, TESTING, REVIEW, RELEASE, DEBUG
    }
    public class Work
    {
        public int Id { get; set; }
        public DateTime DatePlaing { get; set; }
        public DateTime DateRelease { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public TypeWork TypeWork { get; set; }
    }
}
