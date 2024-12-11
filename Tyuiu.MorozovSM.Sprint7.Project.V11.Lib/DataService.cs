namespace Tyuiu.MorozovSM.Sprint7.Project.V11.Lib
{
    public class DataService
    {
        public string[,] CreateMatrixFromFileCSV(string filePath)
        {
            string[,] matrix;
            string fileText = File.ReadAllText(filePath);
            string[] FirstLevel = fileText.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            int rows = FirstLevel.Length;
            int cols = FirstLevel[0].Split(';').Length;
            matrix = new string[rows, cols];
            for (int i = 0; i < rows; i++) for (int j = 0; j < cols; j++) matrix[i, j] = FirstLevel[i].Split(';')[j];
            return matrix;
        }

        public void SaveFileToPath(string filePath, string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string line = "";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == matrix.GetLength(1) - 1)
                        line += matrix[i, j];
                    else line += matrix[i, j] + ";";
                }
                File.AppendAllText(filePath, line + '\n');
            }
        }

        public string[,] RowsAddedInTable(string[,] matrixTable, int NewCountRows)
        {
            string[,] matrixCopyTable = new string[matrixTable.GetLength(0), matrixTable.GetLength(1)];
            for (int i = 0; i < matrixTable.GetLength(0); i++) for (int j = 0; j < matrixTable.GetLength(1); j++) matrixCopyTable[i, j] = matrixTable[i, j];

            matrixTable = new string[NewCountRows, matrixTable.GetLength(1)];

            for (int i = 0; i < matrixTable.GetLength(0); i++) for (int j = 0; j < matrixTable.GetLength(1); j++) 
                {
                    if (i < matrixCopyTable.GetLength(0)) matrixTable[i, j] = matrixCopyTable[i, j];
                }
            return matrixTable;
        }
    }
}
