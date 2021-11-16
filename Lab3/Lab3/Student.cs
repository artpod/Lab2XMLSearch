using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Student
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Cathedra { get; set; }
        public string Average_mark { get; set; }
        public string Year_of_start { get; set; }
        public string Number_of_subjects { get; set; }

        // Checks whether some of the attributes is unset.
        public bool HasEmptyAttribute()
        {
            return Name.Equals("") || Faculty.Equals("") || Cathedra.Equals("")
                 || Average_mark.Equals("") || Year_of_start.Equals("") || Number_of_subjects.Equals("");
        }
    }
}
