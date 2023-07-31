using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._8
{
    public class ClassTeacher: Teacher
    {
        private CClass whichClass;

        public CClass WhichClass
        {
            get { return whichClass; }
            set { whichClass = value; }
        }
    }
}
