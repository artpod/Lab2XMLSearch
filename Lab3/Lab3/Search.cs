using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Lab3
{
    public interface ISearch
    {
        List<Student> Search(SearchCriteria criteria);
    }

    public class DomSearch : ISearch
    {
        private const int _maxCriteriaCount = 4;

        public List<Student> Search(SearchCriteria criteria)
        {
            List<Student> students = new List<Student>();
            XmlDocument doc = new XmlDocument();
            doc.Load(PlaylistReader.playlistPath);

            
            
           

            XmlNodeList studentNodes;

            string xPathCriteria = "";
            string studentSearchTag = "//" + PlaylistReader.studentTag;

            List<string> attributes = new List<string>();
            List<string> criteriaList = criteria.GetCriteriaList();

            attributes.Add(PlaylistReader.faculty);
            attributes.Add(PlaylistReader.average_mark);
            attributes.Add(PlaylistReader.year_of_start);
            attributes.Add(PlaylistReader.number_of_subjects);
            
            for (int i = 0; i < criteriaList.Count; i++)
            {
                if (!criteriaList[i].Equals(""))
                {
                    xPathCriteria += "@" + attributes[i] + "='" + criteriaList[i] + "'and";
                }
            }
            int andLength = 3;
            try
            {
                xPathCriteria = xPathCriteria.Substring(0, xPathCriteria.Length - andLength);
            }
            catch { }
            if (criteria.AllCriteriaAreEmpty())
            {
                studentNodes = doc.SelectNodes(studentSearchTag);
            }
            else
            {
                string xPathQuery = studentSearchTag + "[" + xPathCriteria + "]";
                studentNodes = doc.SelectNodes(xPathQuery);
            }

            foreach(XmlNode studentNode in studentNodes)
            {
                Student student = new Student();
                FillAttributes(student, studentNode);
                students.Add(student);
            }
            //string xPathQuery = ;
            //doc.SelectNodes()

            return students;
        }

        private void FillAttributes(Student student, XmlNode studentNode)
        {
            student.Name = studentNode.Attributes[PlaylistReader.name].Value;
            student.Faculty = studentNode.Attributes[PlaylistReader.faculty].Value;
            student.Cathedra = studentNode.Attributes[PlaylistReader.cathedra].Value;
            student.Average_mark = studentNode.Attributes[PlaylistReader.average_mark].Value;
            student.Year_of_start = studentNode.Attributes[PlaylistReader.year_of_start].Value;
            student.Number_of_subjects = studentNode.Attributes[PlaylistReader.number_of_subjects].Value;
        }

        // Sets the speified student's attributes.
        private void FillAttributes(Student student, XmlAttribute attribute, SearchCriteria criteria)
        {
            string attrName = attribute.Name;
            string attrValue = attribute.Value;

            if (attrName.Equals(PlaylistReader.name))
            {
                student.Name = attrValue;
            }
            if (attrName.Equals(PlaylistReader.faculty))
            {
                student.Faculty = ResolveCriteria(criteria.Faculty, attrName, attrValue);
            }
            if (attrName.Equals(PlaylistReader.cathedra))
            {
                student.Cathedra = attrValue;
            }
            if (attrName.Equals(PlaylistReader.average_mark))
            {
                student.Average_mark = ResolveCriteria(criteria.Average_mark, attrName, attrValue);
            }
            if (attrName.Equals(PlaylistReader.year_of_start))
            {
                student.Year_of_start = ResolveCriteria(criteria.Year_of_start, attrName, attrValue);
            }
            if (attrName.Equals(PlaylistReader.number_of_subjects))
            {
                student.Number_of_subjects = ResolveCriteria(criteria.Number_of_subjects, attrName, attrValue);
            }
        }

        // Works on the search criteria constarints.
        private string ResolveCriteria(string criteria, string attrName, string attrValue)
        {
            if (criteria.Equals(""))
            {
                return attrValue;
            }

            return attrValue.Equals(criteria) ? attrValue : "";
        }
    }

    public class SaxSearch : ISearch
    {
        public List<Student> Search(SearchCriteria criteria)
        {
            List<Student> students = new List<Student>();
            var xmlReader = new XmlTextReader(PlaylistReader.playlistPath);

            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes && xmlReader.NodeType == XmlNodeType.Element)
                {
                    Student student = new Student();

                    while (xmlReader.MoveToNextAttribute())
                    {
                        FillAttributes(student, xmlReader, criteria);
                    }

                    students.Add(student.HasEmptyAttribute() ? null : student);
                }
            }

            return students;
        }

        // Sets the speified student's attributes.
        private void FillAttributes(Student student, XmlReader xmlReader, SearchCriteria criteria)
        {
            string attrName = xmlReader.Name;
            string attrValue = xmlReader.Value;

            if (attrName.Equals(PlaylistReader.name))
            {
                student.Name = attrValue;
            }
            if (attrName.Equals(PlaylistReader.faculty))
            {
                student.Faculty = ResolveCriteria(criteria.Faculty, attrName, attrValue);
            }
            if (attrName.Equals(PlaylistReader.cathedra))
            {
                student.Cathedra = attrValue;
            }
            if (attrName.Equals(PlaylistReader.average_mark))
            {
                student.Average_mark = ResolveCriteria(criteria.Average_mark, attrName, attrValue);
            }
            if (attrName.Equals(PlaylistReader.year_of_start))
            {
                student.Year_of_start = ResolveCriteria(criteria.Year_of_start, attrName, attrValue);
            }
            if (attrName.Equals(PlaylistReader.number_of_subjects))
            {
                student.Number_of_subjects = ResolveCriteria(criteria.Number_of_subjects, attrName, attrValue);
            }
        }

        // Works on the search criteria constarints.
        private string ResolveCriteria(string criteria, string attrName, string attrValue)
        {
            if (criteria.Equals(""))
            {
                return attrValue;
            }

            return attrValue.Equals(criteria) ? attrValue : "";
        }
    }

    public class LinqToXmlSearch : ISearch
    {
        public List<Student> Search(SearchCriteria criteria)
        {
            List<Student> students = new List<Student>();
            var doc = XDocument.Load(PlaylistReader.playlistPath);

            var studentsInList = from obj in doc.Descendants(PlaylistReader.studentTag)
                         select new
                         {
                             name = obj.Attribute(PlaylistReader.name).Value,

                             faculty = criteria.Faculty.Equals("") ?
                             obj.Attribute(PlaylistReader.faculty).Value :
                             criteria.Faculty.Equals(obj.Attribute(PlaylistReader.faculty).Value) ?
                             obj.Attribute(PlaylistReader.faculty).Value : "",

                             cathedra = obj.Attribute(PlaylistReader.cathedra).Value,

                             average_mark = criteria.Average_mark.Equals("") ?
                             obj.Attribute(PlaylistReader.average_mark).Value :
                             criteria.Average_mark.Equals(obj.Attribute(PlaylistReader.average_mark).Value) ?
                             obj.Attribute(PlaylistReader.average_mark).Value : "",

                             year_of_start = criteria.Year_of_start.Equals("") ?
                             obj.Attribute(PlaylistReader.year_of_start).Value :
                             criteria.Year_of_start.Equals(obj.Attribute(PlaylistReader.year_of_start).Value) ?
                             obj.Attribute(PlaylistReader.year_of_start).Value : "",

                             number_of_subjects = criteria.Number_of_subjects.Equals("") ?
                             obj.Attribute(PlaylistReader.number_of_subjects).Value :
                             criteria.Number_of_subjects.Equals(obj.Attribute(PlaylistReader.number_of_subjects).Value) ?
                             obj.Attribute(PlaylistReader.number_of_subjects).Value : "",
                         };

            foreach (var studentElem in studentsInList)
            {
                Student student = new Student();
                student.Name = studentElem.name;
                student.Faculty = studentElem.faculty;//
                student.Cathedra = studentElem.cathedra;
                student.Average_mark = studentElem.average_mark;//
                student.Year_of_start = studentElem.year_of_start; //
                student.Number_of_subjects = studentElem.number_of_subjects; //

                students.Add(student.HasEmptyAttribute() ? null : student);
            }

            return students;
        }
    }
}