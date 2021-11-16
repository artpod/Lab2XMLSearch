using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab3
{
    public struct SearchCriteria
    {
        private readonly string _faculty;
        private readonly string _average_mark;
        private readonly string _year_of_start;
        private readonly string _number_of_subjects;

        public string Faculty { get { return _faculty; } }
        public string Average_mark { get { return _average_mark; } }
        public string Year_of_start { get { return _year_of_start; } }
        public string Number_of_subjects { get { return _number_of_subjects; } }

        public SearchCriteria(XmlNode student)
        {
            _faculty = student.Attributes[PlaylistReader.faculty].Value;
            _average_mark = student.Attributes[PlaylistReader.average_mark].Value;
            _year_of_start = student.Attributes[PlaylistReader.year_of_start].Value;
            _number_of_subjects = student.Attributes[PlaylistReader.number_of_subjects].Value;
        }

        public SearchCriteria(string faculty, string average_mark, string year_of_start, string number_of_subjects)
        {
            _faculty = faculty;
            _average_mark = average_mark;
            _year_of_start = year_of_start;
            _number_of_subjects = number_of_subjects;
        }


        public bool AllCriteriaAreEmpty()
        {
            return _faculty.Equals("") && _average_mark.Equals("") && _year_of_start.Equals("") && _number_of_subjects.Equals("");
        }

        public List<string> GetCriteriaList()
        {
            List<string> result = new List<string>();
            
            result.Add(_faculty);
            result.Add(_average_mark);
            result.Add(_year_of_start);
            result.Add(_number_of_subjects);

            return result;
        }
    }
}
