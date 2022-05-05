using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Departman
    {
        public int DepartmanId { get; set; }
        public string DepartmanName { get; set; }
        public string DepartmanPresident { get; set; }
        public List<Student> Students { get; set; }

    }
}
