using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyExam;

namespace MyExam.Tests
{
    [TestClass]
    public class ExamTests
    {
        
        public TestContext TestContext { get; set; }
        private Exam exam;

        [TestInitialize]
        public void TestInitialize()
        {
            exam = new Exam();
        }
       
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\thema01.csv", "thema01#csv", DataAccessMethod.Sequential), DeploymentItem("thema01.csv"), TestMethod]
        public void Thema_01()
        {
            
            float first = Convert.ToSingle(TestContext.DataRow["first"]);
            float second = Convert.ToSingle(TestContext.DataRow["second"]);
            float expected = Convert.ToSingle(TestContext.DataRow["avg"]);
            float actual = exam.Average(first, second);
            Assert.AreEqual(expected, actual);
        }

     
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\thema02.csv", "thema02#csv", DataAccessMethod.Sequential), DeploymentItem("thema02.csv"), TestMethod]
        public void Thema_02()
        {
            int num = Convert.ToInt32(TestContext.DataRow["numbers"]);
            int expected = Convert.ToInt32(TestContext.DataRow["max"]);
            int actual = exam.MinMax(num);
            Assert.AreEqual(expected, actual);
        }

  
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\thema03.csv", "thema03#csv", DataAccessMethod.Sequential), DeploymentItem("thema03.csv"), TestMethod]
        public void Thema_03()
        {
            int num = Convert.ToInt32(TestContext.DataRow["numbers"]);
            String expected = Convert.ToString(TestContext.DataRow["sorted"]);
            String actual = exam.BubbleSort(num);
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\thema04.csv", "thema04#csv", DataAccessMethod.Sequential), DeploymentItem("thema04.csv"), TestMethod]
        public void Thema_04()
        {
            int num = Convert.ToInt32(TestContext.DataRow["numbers"]);
            int key = Convert.ToInt32(TestContext.DataRow["search"]);
            String expected = Convert.ToString(TestContext.DataRow["found"]);
            String actual = exam.BinarySearch(num, key);
            Assert.AreEqual(expected, actual);
        }
    }
}
