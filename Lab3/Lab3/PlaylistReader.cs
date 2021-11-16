using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Lab3
{
    public partial class PlaylistReader : Form
    {
        public const string playlistPath = @"C:\Users\Admin\Desktop\Lab2OOP\Lab3\Lab3\playlist.xml";
        private const string _transformerPath = @"C:\Users\Admin\Desktop\Lab2OOP\Lab3\Lab3\transformer.xsl";
        private const string _htmlPath = @"C:\Users\Admin\Desktop\Lab2OOP\Lab3\Lab3\output.html";
        public const string studentTag = "student";
        public const string name = "Name";
        public const string faculty = "Faculty";
        public const string cathedra = "Cathedra";
        public const string average_mark = "Average_mark";
        public const string year_of_start = "Year_of_start";
        public const string number_of_subjects = "Number_of_subjects";
        private const string _result = "Результат ";
        private const string _separator = "---";

        public PlaylistReader()
        {
            InitializeComponent();
        }

        private void PlaylistReader_Load(object sender, EventArgs e)
        {
            FillCriteriaLists();
        }

        // Retrieves students' data from the playlist file to be added to criteria lists.
        private void FillCriteriaLists()
        {
            XmlDocument doc = new XmlDocument();
                doc.Load(playlistPath);

            XmlElement root = doc.DocumentElement;
            XmlNodeList students = root.SelectNodes(studentTag);

            for (int i = 0; i < students.Count; i++)
            {
                XmlNode student = students.Item(i);
                SearchCriteria criteria = new SearchCriteria(student);
                AddCriteria(criteria);
            }
        }

        // Adds search criteria to lists.
        private void AddCriteria(SearchCriteria criteria)
        {
            if (!facultyDropList.Items.Contains(criteria.Faculty))
            {
                facultyDropList.Items.Add(criteria.Faculty);
            }
            if (!averageDropList.Items.Contains(criteria.Average_mark))
            {
                averageDropList.Items.Add(criteria.Average_mark);
            }
            if (!yearDropList.Items.Contains(criteria.Year_of_start))
            {
                yearDropList.Items.Add(criteria.Year_of_start);
            }
            if (!disciplineDropList.Items.Contains(criteria.Number_of_subjects))
            {
                disciplineDropList.Items.Add(criteria.Number_of_subjects);
            }
        }

        // Invoked when 'Search' button is clicked.
        private void searchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }

        // Performs the search in the playlist under specified criteria.
        private void Search()
        {
            ISearch search = new DomSearch();
            
            if (saxBtn.Checked)
            {
                search = new SaxSearch();
            }
            if (linqToXmlBtn.Checked)
            {
                search = new LinqToXmlSearch();
            }

            List<Student> students = search.Search(GetSearchCriteria());
            OutputSearchResults(students);
        }

        // Returns the specified search criteria.
        private SearchCriteria GetSearchCriteria()
        {
            string faculty = facultyCheckBox.Checked ? facultyDropList.Text : "";
            string average_mark = averageCheckBox.Checked ? averageDropList.Text : "";
            string year_of_start = yearCheckBox.Checked ? yearDropList.Text : "";
            string number_of_subjects = disciplineCheckBox.Checked ? disciplineDropList.Text : "";

            return new SearchCriteria(faculty, average_mark, year_of_start, number_of_subjects);
        }

        // Outputs search resutls into the search results viewer.
        private void OutputSearchResults(List<Student> students)
        {
            searchResultsViewer.Text = "";

            int resultCount = 0;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i] != null)
                {
                    searchResultsViewer.Text += _result + (resultCount + 1) + "\n";
                    searchResultsViewer.Text += name + ": " + students[i].Name + "\n";
                    searchResultsViewer.Text += faculty + ": " + students[i].Faculty + "\n";
                    searchResultsViewer.Text += cathedra + ": " + students[i].Cathedra + "\n";
                    searchResultsViewer.Text += average_mark + ": " + students[i].Average_mark + "\n";
                    searchResultsViewer.Text += year_of_start + ": " + students[i].Year_of_start + "\n";
                    searchResultsViewer.Text += number_of_subjects + ": " + students[i].Number_of_subjects + "\n";
                    searchResultsViewer.Text += _separator + _separator + "\n";
                    resultCount++;
                }
            }
        }

        // Invoked when 'Artist' checkbox is (un)checked.
       

        // Invoked when 'Genre' checkbox is (un)checked.
        private void averageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            averageDropList.Enabled = !averageDropList.Enabled;
            if (averageCheckBox.Checked)
            {
                averageDropList.Text = averageDropList.Items[0].ToString();
            }
        }

        // Invoked when 'Year' checkbox is (un)checked.
        private void facultyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
            facultyDropList.Enabled = !facultyDropList.Enabled;
            if (facultyCheckBox.Checked)
                facultyDropList.Text = facultyDropList.Items[0].ToString();
        }

        // Invoked when 'Label' checkbox is (un)checked.
        private void disciplineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            disciplineDropList.Enabled = !disciplineDropList.Enabled;
            if (disciplineCheckBox.Checked)
            {
                disciplineDropList.Text = disciplineDropList.Items[0].ToString();
            }
        }

        //Invoked when 'Forge HTML' button is clicked.
        private void forgeHtmlBtn_Click(object sender, EventArgs e)
        {
            ForgeHtml();
        }

        // Transforms the XML playlist file into an HTML file containing table-reprsented playlist.
        private void ForgeHtml()
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load(_transformerPath);
            xct.Transform(playlistPath, _htmlPath);
        }

        private void yearCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            yearDropList.Enabled = !yearDropList.Enabled;
            if (yearCheckBox.Checked)
            {
                yearDropList.Text = yearDropList.Items[0].ToString();
            }
        }
    }
}