using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCAdmin.Model
{
    public enum TypeOperation
    { 
        Arrival, Expense
    }
    public class SemmiType
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SemmiType> Types { get; set; }
    }
    public class Operation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Worker Worker { get; set; }
        public double Money { get; set; }
        public TypeOperation TypeOperation { get; set; }
        public SemmiType SemmiType { get; set; }
        public string About { get; set; }
        public DateTime Date { get; set; }
    }
}
