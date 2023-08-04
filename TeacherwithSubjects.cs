using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject_4
{
    public class TeacherwithSubjects
    {
        public Teacher Teacher { get; set; }
        public List<Subject> Subjects { get; set; }

        public TeacherwithSubjects()
        {
            Subjects = new List<Subject>();
        }
    }
}
