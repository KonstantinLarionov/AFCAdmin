using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCAdmin.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateAdd { get; set; }
        public List<ContactOnProject> ContactsOnProject { get; set; } = new List<ContactOnProject>();
    }
}
