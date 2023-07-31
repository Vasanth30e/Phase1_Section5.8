using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Phase1Section5._8
{
    public class SubjectTeacher: Teacher
    {
        private Subject whichSubject;

        public Subject WhichSubject
        {
            get { return whichSubject; }
            set { whichSubject = value; }
        }
    }
}
