using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;
using System.Collections.Generic;

namespace TestDom
{
    [TestClass]
    public class TestDom
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Search by artist and genre.
            SearchCriteria criteria = new SearchCriteria("", "83", "2018", "");

            // Student (should be first in the found list).
            string expectedName = "Думенко Роксолан Бажанович";
            string expectedFaculty = "Філософський факультет";
            string expectedCathedra = "Кафедра історії філософії";
            string expectedAverage_mark = "83";
            string expectedYear_of_start = "2018";
            string expectedNumber_of_subjects = "6";

            ISearch search = new DomSearch();
            List<Student> students = search.Search(criteria);

            Assert.AreEqual(expectedName, students[0].Name);
            Assert.AreEqual(expectedFaculty, students[0].Faculty);
            Assert.AreEqual(expectedCathedra, students[0].Cathedra);
            Assert.AreEqual(expectedAverage_mark, students[0].Average_mark);
            Assert.AreEqual(expectedYear_of_start, students[0].Year_of_start);
            Assert.AreEqual(expectedNumber_of_subjects, students[0].Number_of_subjects);
        }
    }
}
