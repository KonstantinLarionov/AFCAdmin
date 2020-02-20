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
    public enum Сompleteness
    { 
        New,
        InWork,
        Done
    }
    public enum DifficultyLevel
    { 
        Hard,Medium,Easy
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
        public Сompleteness Сompleteness { get; set; }
        public DifficultyLevel Difficulty { get; set; }
    }
}
