using Tyuiu.MorozovSM.Sprint7.Project.V11.Lib;

namespace Tyuiu.MorozovSM.Sprint7.Project.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckCreateMatrixFromFileCSV()
        {
            string path = Path.Combine(Path.GetTempPath(), "Table.csv");
            string[,] matrixRes = ds.CreateMatrixFromFileCSV(path);
            string[,] matrixWait = { {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10" },
                {"11","12","13","14","15","16","17","18","19","20"},
                {"21","22","23","24","25","26","27","28","29","30" } };
            CollectionAssert.AreEqual(matrixRes, matrixWait);
        }
        [TestMethod]
        public void CheckRowsAddedInTable()
        {
            string[,] matrixTable = { { "1", "2", "3", }, { "4", "5", "6" } };
            string[,] matrixRes = ds.RowsAddedInTable(matrixTable, 5);
            string[,] matrixWait = { { "1", "2", "3", }, { "4", "5", "6" } , { null ,null ,null } , { null, null, null } , { null, null, null } };
            CollectionAssert.AreEquivalent(matrixRes, matrixWait);
        }
        [TestMethod]
        public void CheckSaveFileToPath()
        {
            string[,] matrixTable = { { "1", "2", "3", }, { "4", "5", "6" } };
            string path = Path.Combine(Path.GetTempPath(), "CheckTable.csv");
            ds.SaveFileToPath(path, matrixTable);
            Assert.IsTrue(File.Exists(path));
        }
    }
}