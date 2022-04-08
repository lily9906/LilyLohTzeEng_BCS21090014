using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilyLohTzeEng_BCS21090014
{
    class ObjectOrientedProgrammingCourse
    {
        public StudentDetail(string studentname, string studentid, string identificationcard, decimal mark)
        {
   
            StudentName = studentname;
            StudentId = studentid;
            IdentificationCard = identificationcard;
            Mark = mark;
        }
        public string StudentName { get; set; }
        public string StudentId { get; set; }
        public string IdentificationCard { get; set; }
        public decimal Mark { get; set; }

    }
}

