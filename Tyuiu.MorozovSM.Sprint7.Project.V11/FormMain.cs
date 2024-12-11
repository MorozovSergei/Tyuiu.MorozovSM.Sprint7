using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using Tyuiu.MorozovSM.Sprint7.Project.V11.Lib;

namespace Tyuiu.MorozovSM.Sprint7.Project.V11
{
    public partial class FormMain : Form
    {

        DataService ds = new DataService();
        string pathLoadTable;
        string pathTable = Path.Combine(Path.GetTempPath(), "Table.csv");
        string[,] matrixTable;
        string[,] matrixOldTable;
        bool flagChangeValueTable = false;
        int indexStaticColumnInComboBox;
        int indexFilterColumnInComboBox;
        int RowNumber = 0;
        public FormMain()
        {
            InitializeComponent();
            if (!File.Exists(pathTable)) File.WriteAllText(pathTable, ";;;;;;;;;;0");
            matrixTable = ds.CreateMatrixFromFileCSV(pathTable);
            for (int i = 0; i < matrixTable.GetLength(0); i++)
            {
                dataGridViewTable_MSM.Rows.Add();
                for (int j = 0; j < matrixTable.GetLength(1); j++) dataGridViewTable_MSM.Rows[i].Cells[j].Value = matrixTable[i, j];
            }
            flagChangeValueTable = true;
            RowNumber = matrixTable.GetLength(0);
        }

        private void buttonSaveFileInTable_MSM_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathTable)) File.Delete(pathTable);
            ds.SaveFileToPath(pathTable, matrixTable);
        }

        private void buttonSaveAnotherFile_MSM_Click(object sender, EventArgs e)
        {

            saveFileDialog_MSM.FileName = "FileTable.csv";
            saveFileDialog_MSM.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_MSM.ShowDialog();
            string NewPath = saveFileDialog_MSM.FileName;
            ds.SaveFileToPath(NewPath, matrixTable);

        }

        private void buttonLoadTable_MSM_Click(object sender, EventArgs e)
        {

            openFileDialog_MSM.ShowDialog();
            pathLoadTable = openFileDialog_MSM.FileName;
            if (Path.Exists(pathLoadTable))
            {
                matrixOldTable = matrixTable;
                matrixTable = ds.CreateMatrixFromFileCSV(pathLoadTable);

                flagChangeValueTable = false;
                dataGridViewTable_MSM.Rows.Clear();
                for (int i = 0; i < matrixTable.GetLength(0); i++)
                {
                    dataGridViewTable_MSM.Rows.Add();
                    for (int j = 0; j < matrixTable.GetLength(1); j++) dataGridViewTable_MSM.Rows[i].Cells[j].Value = matrixTable[i, j];
                }
                flagChangeValueTable = true;

                buttonLoadTableClose_MSM.Visible = true;
                buttonLoadTableSave_MSM.Visible = true;
            }
            buttonSaveTableInFile_MSM.Visible = false;
        }

        private void buttonLoadTableClose_MSM_Click(object sender, EventArgs e)
        {
            matrixTable = matrixOldTable;
            flagChangeValueTable = false;
            dataGridViewTable_MSM.Rows.Clear();
            for (int i = 0; i < matrixTable.GetLength(0); i++)
            {
                dataGridViewTable_MSM.Rows.Add();
                for (int j = 0; j < matrixTable.GetLength(1); j++) dataGridViewTable_MSM.Rows[i].Cells[j].Value = matrixTable[i, j];
            }
            flagChangeValueTable = true;

            buttonLoadTableClose_MSM.Visible = false;
            buttonLoadTableSave_MSM.Visible = false;
            buttonSaveTableInFile_MSM.Visible = true;
        }

        private void buttonLoadTableSave_MSM_Click(object sender, EventArgs e)
        {
            matrixOldTable = ds.RowsAddedInTable(matrixOldTable, matrixTable.GetLength(0) + matrixOldTable.GetLength(0));
            for (int i = 0; i < matrixTable.GetLength(0); i++) for (int j = 0; j < matrixTable.GetLength(1); j++) matrixOldTable[i + matrixOldTable.GetLength(0) - matrixTable.GetLength(0), j] = matrixTable[i, j];
            matrixTable = matrixOldTable;
            flagChangeValueTable = false;
            dataGridViewTable_MSM.Rows.Clear();
            for (int i = 0; i < matrixTable.GetLength(0); i++)
            {
                dataGridViewTable_MSM.Rows.Add();
                for (int j = 0; j < matrixTable.GetLength(1); j++) dataGridViewTable_MSM.Rows[i].Cells[j].Value = matrixTable[i, j];
            }
            flagChangeValueTable = true;

            buttonLoadTableClose_MSM.Visible = false;
            buttonLoadTableSave_MSM.Visible = false;
            buttonSaveTableInFile_MSM.Visible = true;
        }

        private void dataGridViewTable_MSM_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && flagChangeValueTable)
            {
                int LineOffset = Convert.ToInt32(dataGridViewTable_MSM.Rows[e.RowIndex].Cells[10].Value);
                if (dataGridViewTable_MSM.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    matrixTable[LineOffset, e.ColumnIndex] = dataGridViewTable_MSM.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                else
                    matrixTable[LineOffset, e.ColumnIndex] = "";
            }
        }

        private void dataGridViewTable_MSM_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (flagChangeValueTable)
            {
                matrixTable = ds.RowsAddedInTable(matrixTable, dataGridViewTable_MSM.RowCount - 1);
                matrixTable[matrixTable.GetLength(0) - 1, 10] = RowNumber.ToString();
                dataGridViewTable_MSM.Rows[matrixTable.GetLength(0) - 1].Cells[10].Value = RowNumber++;
            }
        }

        private void buttonSearch_MSM_Click(object sender, EventArgs e)
        {
            if (textBoxSearch_MSM.Text == "")
            {
                flagChangeValueTable = false;
                dataGridViewTable_MSM.Rows.Clear();
                for (int i = 0; i < matrixTable.GetLength(0); i++)
                {
                    dataGridViewTable_MSM.Rows.Add();
                    for (int j = 0; j < matrixTable.GetLength(1); j++) dataGridViewTable_MSM.Rows[i].Cells[j].Value = matrixTable[i, j];
                }
                flagChangeValueTable = true;
            }
            else
            {
                string LineIndex = "";
                for (int i = 0; i < matrixTable.GetLength(0); i++) for (int j = 0; j < matrixTable.GetLength(1); j++)
                        if (matrixTable[i, j].ToString().Contains(textBoxSearch_MSM.Text)) LineIndex += i.ToString() + ";";
                if (LineIndex == "")
                {
                    flagChangeValueTable = false;
                    dataGridViewTable_MSM.Rows.Clear();
                    flagChangeValueTable = true;
                }
                else
                {
                    int RowsNumber = 0;
                    flagChangeValueTable = false;
                    dataGridViewTable_MSM.Rows.Clear();

                    foreach (string i in LineIndex.Trim(';').Split(';'))
                    {
                        dataGridViewTable_MSM.Rows.Add();
                        for (int j = 0; j < matrixTable.GetLength(1); j++) dataGridViewTable_MSM.Rows[RowsNumber].Cells[j].Value = matrixTable[Convert.ToInt32(i), j];
                        RowsNumber++;
                    }
                    flagChangeValueTable = true;
                }
            }
        }

        private void comboBoxIndexFilterColumn_MSM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxIndexFilterColumn_MSM_TextChanged(object sender, EventArgs e)
        {
            string AllTypes = "";
            groupBoxFilter_MSM.Visible = true;
            indexFilterColumnInComboBox = comboBoxIndexFilterColumn_MSM.SelectedIndex;
            checkedListBoxFilter_MSM.Items.Clear();
            for (int i = 0; i < matrixTable.GetLength(0); i++)
            {
                if (!AllTypes.Trim(';').Split(";").Any(str => str == matrixTable[i, indexFilterColumnInComboBox])) AllTypes += matrixTable[i, indexFilterColumnInComboBox] + ";";
            }
            foreach (string name in AllTypes.Trim(';').Split(";", StringSplitOptions.RemoveEmptyEntries)) checkedListBoxFilter_MSM.Items.Add(name, true);
        }

        private void buttonResetFilter_MSM_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxFilter_MSM.Items.Count; i++)
            {
                checkedListBoxFilter_MSM.SetItemChecked(i, true);
            }
        }

        private void buttonUseFilter_MSM_Click(object sender, EventArgs e)
        {
            comboBoxIndexStaticColumn_MSM.Text = comboBoxIndexStaticColumn_MSM.Text;
            string CheckItems = "";
            string LineIndex = "";
            foreach (var item in checkedListBoxFilter_MSM.CheckedItems) CheckItems += item.ToString() + ";";
            for (int i = 0; i < matrixTable.GetLength(0); i++)
            {
                if (CheckItems.Trim(';').Split(";").Any(str => str == matrixTable[i, indexFilterColumnInComboBox]))
                {
                    LineIndex += i.ToString() + ";";
                }
            }
            flagChangeValueTable = false;
            dataGridViewTable_MSM.Rows.Clear();
            int RowNumber = 0;
            foreach (string i in LineIndex.Trim(';').Split(';'))
            {
                dataGridViewTable_MSM.Rows.Add();
                for (int j = 0; j < matrixTable.GetLength(1); j++) dataGridViewTable_MSM.Rows[RowNumber].Cells[j].Value = matrixTable[Convert.ToInt32(i), j];
                RowNumber++;
            }
            flagChangeValueTable = true;
            chartGraphic_MSM.Titles.Clear();
            chartGraphic_MSM.Series[0].Points.Clear();
            dataGridViewFunction_MSM.Rows.Clear();
            string SummColumn = "";
            for (int i = 0; i < dataGridViewTable_MSM.RowCount-1; i++) SummColumn += dataGridViewTable_MSM.Rows[i].Cells[indexStaticColumnInComboBox].Value.ToString() + ';';
            string[] MassivColumnStr = SummColumn.Trim(';').Split(";", StringSplitOptions.RemoveEmptyEntries);
            dataGridViewFunction_MSM.Rows[0].Cells[0].Value = "Счетчик";
            dataGridViewFunction_MSM.Rows[0].Cells[1].Value = MassivColumnStr.Count();
            try
            {
                double[] MassivColumnDouble = new double[MassivColumnStr.Length];
                for (int i = 0; i < MassivColumnStr.Length; i++) MassivColumnDouble[i] = double.Parse(MassivColumnStr[i]);
                dataGridViewFunction_MSM.Rows.Add("Сумма", MassivColumnDouble.Sum());
                dataGridViewFunction_MSM.Rows.Add("Среднее", double.Round(MassivColumnDouble.Sum() / MassivColumnDouble.Count(), 3));
                dataGridViewFunction_MSM.Rows.Add("Максимум", MassivColumnDouble.Max());
                dataGridViewFunction_MSM.Rows.Add("Минимум", MassivColumnDouble.Min());
                dataGridViewFunction_MSM.Visible = true;
                chartGraphic_MSM.Titles.Add("График выбранного столбца");
                chartGraphic_MSM.ChartAreas[0].AxisX.Title = "Номер строки";
                chartGraphic_MSM.ChartAreas[0].AxisY.Title = "Значение";
                string[] LineIndexMassiv = LineIndex.Trim(';').Split(';');
                for (int i = 0; i < LineIndexMassiv.GetLength(0); i++)
                {
                    if (matrixTable[Convert.ToInt32(LineIndexMassiv[i]), indexStaticColumnInComboBox] != null && matrixTable[Convert.ToInt32(LineIndexMassiv[i]), indexStaticColumnInComboBox] != "")
                        chartGraphic_MSM.Series[0].Points.AddXY(i + 1, matrixTable[Convert.ToInt32(LineIndexMassiv[i]), indexStaticColumnInComboBox]);
                }
                chartGraphic_MSM.Visible = true;
            }
            catch { }
        }

        private void comboBoxIndexStaticColumn_MSM_TextChanged(object sender, EventArgs e)
        {
            chartGraphic_MSM.Visible = false;
            chartGraphic_MSM.Titles.Clear();
            chartGraphic_MSM.Series[0].Points.Clear();
            dataGridViewFunction_MSM.Rows.Clear();
            string SummColumn = "";
            indexStaticColumnInComboBox = comboBoxIndexStaticColumn_MSM.SelectedIndex;
            for (int i = 0; i < dataGridViewTable_MSM.RowCount-1; i++) SummColumn += dataGridViewTable_MSM.Rows[i].Cells[indexStaticColumnInComboBox].Value.ToString() + ';';
            string[] MassivColumnStr = SummColumn.Trim(';').Split(";", StringSplitOptions.RemoveEmptyEntries);
            dataGridViewFunction_MSM.Visible = true;
            dataGridViewFunction_MSM.Rows[0].Cells[0].Value = "Счетчик";
            dataGridViewFunction_MSM.Rows[0].Cells[1].Value = MassivColumnStr.Count();
            try
            {
                double[] MassivColumnDouble = new double[MassivColumnStr.Length];
                for (int i = 0; i < MassivColumnStr.Length; i++) MassivColumnDouble[i] = double.Parse(MassivColumnStr[i]);
                dataGridViewFunction_MSM.Rows.Add("Сумма", MassivColumnDouble.Sum());
                dataGridViewFunction_MSM.Rows.Add("Среднее", double.Round(MassivColumnDouble.Sum() / MassivColumnDouble.Count(), 3));
                dataGridViewFunction_MSM.Rows.Add("Максимум", MassivColumnDouble.Max());
                dataGridViewFunction_MSM.Rows.Add("Минимум", MassivColumnDouble.Min());
                dataGridViewFunction_MSM.Visible = true;
                chartGraphic_MSM.Titles.Add("График выбранного столбца");
                chartGraphic_MSM.ChartAreas[0].AxisX.Title = "Номер строки";
                chartGraphic_MSM.ChartAreas[0].AxisY.Title = "Значение";
                for (int i = 0; i < matrixTable.GetLength(0); i++)
                {
                    if (matrixTable[i, indexStaticColumnInComboBox] != null && matrixTable[i, indexStaticColumnInComboBox] != "")
                        chartGraphic_MSM.Series[0].Points.AddXY(i + 1, matrixTable[i, indexStaticColumnInComboBox]);
                }
                chartGraphic_MSM.Visible = true;
            }
            catch { }
        }

        private void buttonResetTable_MSM_Click(object sender, EventArgs e)
        {
            comboBoxIndexStaticColumn_MSM.Text = "";
            comboBoxIndexFilterColumn_MSM.Text = "";
            groupBoxFilter_MSM.Visible = false;
            chartGraphic_MSM.Visible = false;
            dataGridViewFunction_MSM.Visible = false;
            checkedListBoxFilter_MSM.Items.Clear();
            flagChangeValueTable = false;
            dataGridViewTable_MSM.Rows.Clear();
            for (int i = 0; i < matrixTable.GetLength(0); i++)
            {
                dataGridViewTable_MSM.Rows.Add();
                for (int j = 0; j < matrixTable.GetLength(1); j++) dataGridViewTable_MSM.Rows[i].Cells[j].Value = matrixTable[i, j];
            }
            flagChangeValueTable = true;
        }

        private void buttonMenu_MSM_Click(object sender, EventArgs e)
        {
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            Location = new Point(resolution.Width / 2 - 150, resolution.Height / 2 - 200);
            ClientSize = new Size(284, 361);
            MinimumSize = new Size(300, 400);
            MaximizeBox = false;
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            panelMenu_MSM.Visible = false;
            panelStatistics_MSM.Visible = false;
            panelTable_MSM.Visible = false;
            textBoxInform_MSM.Visible = true;
            buttonAboutProgram_MSM.Visible = true;
            buttonManual_MSM.Visible = true;
            buttonMain_MSM.Visible = true;
        }

        private void buttonManual_MSM_Click(object sender, EventArgs e)
        {
            FormManual fm = new FormManual();
            fm.ShowDialog();
        }

        private void buttonMain_MSM_Click(object sender, EventArgs e)
        {
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            Location = new Point(resolution.Width / 2 - 585, resolution.Height / 2 - 361);
            Location = new Point(300, 150);
            ClientSize = new Size(1154, 683);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimumSize = new Size(1170, 722);
            panelMenu_MSM.Visible = true;
            panelStatistics_MSM.Visible = true;
            panelTable_MSM.Visible = true;
            textBoxInform_MSM.Visible = false;
            buttonAboutProgram_MSM.Visible = false;
            buttonManual_MSM.Visible = false;
            buttonMain_MSM.Visible = false;
        }

        private void buttonAboutProgram_MSM_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void dataGridViewTable_MSM_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            matrixTable = new string[matrixTable.GetLength(0) - 1, matrixTable.GetLength(1)];
            for (int i = 0; i < matrixTable.GetLength(0); i++) for (int j = 0; j < matrixTable.GetLength(1); j++) matrixTable[i, j] = dataGridViewTable_MSM.Rows[i].Cells[j].Value.ToString();
        }
    }
}