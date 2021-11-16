using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;
using System.Collections.Generic;

namespace TestSax
{
    [TestClass]
    public class TestSax
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Search by year and label.
            SearchCriteria criteria = new SearchCriteria("Факультет комп'ютерних наук та кібернетики", "97", "", "");

            // Song (should be fifth in the found list).
            string expectedName = "Дашенко Юліан Ігорович";
            string expectedFaculty = "Факультет комп'ютерних наук та кібернетики";
            string expectedCathedra = "Кафедра обчислювальної математики";
            string expectedAverage_mark = "97";
            string expectedYear_of_start = "2018";
            string expectedNumber_of_subjects = "7";

            ISearch search = new SaxSearch();
            List<Student> students = search.Search(criteria);

            Assert.AreEqual(expectedName, students[6].Name);
            Assert.AreEqual(expectedFaculty, students[6].Faculty);
            Assert.AreEqual(expectedCathedra, students[6].Cathedra);
            Assert.AreEqual(expectedAverage_mark, students[6].Average_mark);
            Assert.AreEqual(expectedYear_of_start, students[6].Year_of_start);
            Assert.AreEqual(expectedNumber_of_subjects, students[6].Number_of_subjects);
        }
    }
}
