using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Sefer
    {
        public int SeferId { get; set; }
        public int FromCityId { get; set; }
        public int ToCityId { get; set; }
        public DateTime Date { get; set; }


    }
}
