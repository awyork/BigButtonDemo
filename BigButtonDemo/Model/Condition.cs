using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigButtonDemo.Model
{
    public class Condition
    {
        public Day day { get; set; }
        public Night night { get; set; }
    }

    public class Day
    {
        public string desc { get; set; }
    }

    public class Night
    {
        public string desc { get; set; }
    }
}
