namespace Tyuiu.MorozovSM.Sprint7.Project.V11
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelMenu_MSM = new Panel();
            groupBoxSearch_MSM = new GroupBox();
            textBoxSearch_MSM = new TextBox();
            buttonSearch_MSM = new Button();
            buttonMenu_MSM = new Button();
            buttonResetTable_MSM = new Button();
            buttonSaveAnotherFile_MSM = new Button();
            buttonLoadTableClose_MSM = new Button();
            buttonLoadTableSave_MSM = new Button();
            buttonLoadTable_MSM = new Button();
            buttonSaveTableInFile_MSM = new Button();
            panelTable_MSM = new Panel();
            dataGridViewTable_MSM = new DataGridView();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Patronymic = new DataGridViewTextBoxColumn();
            HomeAddress = new DataGridViewTextBoxColumn();
            Telephone = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            DateOfEnrollment = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            Education = new DataGridViewTextBoxColumn();
            NumberRow = new DataGridViewTextBoxColumn();
            openFileDialog_MSM = new OpenFileDialog();
            panelStatistics_MSM = new Panel();
            groupBoxFilter_MSM = new GroupBox();
            checkedListBoxFilter_MSM = new CheckedListBox();
            buttonResetFilter_MSM = new Button();
            buttonUseFilter_MSM = new Button();
            chartGraphic_MSM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_MSM = new DataGridView();
            Function = new DataGridViewTextBoxColumn();
            Result = new DataGridViewTextBoxColumn();
            comboBoxIndexStaticColumn_MSM = new ComboBox();
            comboBoxIndexFilterColumn_MSM = new ComboBox();
            saveFileDialog_MSM = new SaveFileDialog();
            toolTip_MSM = new ToolTip(components);
            buttonMain_MSM = new Button();
            buttonManual_MSM = new Button();
            buttonAboutProgram_MSM = new Button();
            textBoxInform_MSM = new TextBox();
            panelMenu_MSM.SuspendLayout();
            groupBoxSearch_MSM.SuspendLayout();
            panelTable_MSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_MSM).BeginInit();
            panelStatistics_MSM.SuspendLayout();
            groupBoxFilter_MSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGraphic_MSM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_MSM).BeginInit();
            SuspendLayout();
            // 
            // panelMenu_MSM
            // 
            panelMenu_MSM.Controls.Add(groupBoxSearch_MSM);
            panelMenu_MSM.Controls.Add(buttonMenu_MSM);
            panelMenu_MSM.Controls.Add(buttonResetTable_MSM);
            panelMenu_MSM.Controls.Add(buttonSaveAnotherFile_MSM);
            panelMenu_MSM.Controls.Add(buttonLoadTableClose_MSM);
            panelMenu_MSM.Controls.Add(buttonLoadTableSave_MSM);
            panelMenu_MSM.Controls.Add(buttonLoadTable_MSM);
            panelMenu_MSM.Controls.Add(buttonSaveTableInFile_MSM);
            panelMenu_MSM.Dock = DockStyle.Top;
            panelMenu_MSM.Location = new Point(0, 0);
            panelMenu_MSM.Name = "panelMenu_MSM";
            panelMenu_MSM.Size = new Size(284, 119);
            panelMenu_MSM.TabIndex = 0;
            panelMenu_MSM.Visible = false;
            // 
            // groupBoxSearch_MSM
            // 
            groupBoxSearch_MSM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxSearch_MSM.Controls.Add(textBoxSearch_MSM);
            groupBoxSearch_MSM.Controls.Add(buttonSearch_MSM);
            groupBoxSearch_MSM.Font = new Font("Segoe UI", 10F);
            groupBoxSearch_MSM.Location = new Point(125, 0);
            groupBoxSearch_MSM.Name = "groupBoxSearch_MSM";
            groupBoxSearch_MSM.Size = new Size(153, 53);
            groupBoxSearch_MSM.TabIndex = 11;
            groupBoxSearch_MSM.TabStop = false;
            groupBoxSearch_MSM.Text = "Поиск";
            // 
            // textBoxSearch_MSM
            // 
            textBoxSearch_MSM.Location = new Point(6, 22);
            textBoxSearch_MSM.Name = "textBoxSearch_MSM";
            textBoxSearch_MSM.Size = new Size(117, 25);
            textBoxSearch_MSM.TabIndex = 9;
            // 
            // buttonSearch_MSM
            // 
            buttonSearch_MSM.BackColor = SystemColors.Window;
            buttonSearch_MSM.FlatStyle = FlatStyle.Flat;
            buttonSearch_MSM.Image = (Image)resources.GetObject("buttonSearch_MSM.Image");
            buttonSearch_MSM.Location = new Point(122, 22);
            buttonSearch_MSM.Name = "buttonSearch_MSM";
            buttonSearch_MSM.Size = new Size(25, 25);
            buttonSearch_MSM.TabIndex = 10;
            toolTip_MSM.SetToolTip(buttonSearch_MSM, "Поиск по заданному слову");
            buttonSearch_MSM.UseVisualStyleBackColor = false;
            buttonSearch_MSM.Click += buttonSearch_MSM_Click;
            // 
            // buttonMenu_MSM
            // 
            buttonMenu_MSM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMenu_MSM.Font = new Font("Segoe UI", 10F);
            buttonMenu_MSM.Location = new Point(213, 59);
            buttonMenu_MSM.Name = "buttonMenu_MSM";
            buttonMenu_MSM.Size = new Size(65, 29);
            buttonMenu_MSM.TabIndex = 8;
            buttonMenu_MSM.Text = "Меню";
            toolTip_MSM.SetToolTip(buttonMenu_MSM, "Выйти в меню");
            buttonMenu_MSM.UseVisualStyleBackColor = true;
            buttonMenu_MSM.Click += buttonMenu_MSM_Click;
            // 
            // buttonResetTable_MSM
            // 
            buttonResetTable_MSM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonResetTable_MSM.Font = new Font("Segoe UI", 10F);
            buttonResetTable_MSM.Location = new Point(125, 59);
            buttonResetTable_MSM.Name = "buttonResetTable_MSM";
            buttonResetTable_MSM.Size = new Size(87, 29);
            buttonResetTable_MSM.TabIndex = 19;
            buttonResetTable_MSM.Text = "Сбросить";
            toolTip_MSM.SetToolTip(buttonResetTable_MSM, "Вернуть основную таблицу без изменений");
            buttonResetTable_MSM.UseVisualStyleBackColor = true;
            buttonResetTable_MSM.Click += buttonResetTable_MSM_Click;
            // 
            // buttonSaveAnotherFile_MSM
            // 
            buttonSaveAnotherFile_MSM.Font = new Font("Segoe UI", 10F);
            buttonSaveAnotherFile_MSM.Location = new Point(12, 82);
            buttonSaveAnotherFile_MSM.Name = "buttonSaveAnotherFile_MSM";
            buttonSaveAnotherFile_MSM.Size = new Size(113, 29);
            buttonSaveAnotherFile_MSM.TabIndex = 5;
            buttonSaveAnotherFile_MSM.Text = "Сохранить как";
            toolTip_MSM.SetToolTip(buttonSaveAnotherFile_MSM, "Сохранить основную таблицу в отдельный файл");
            buttonSaveAnotherFile_MSM.UseVisualStyleBackColor = true;
            buttonSaveAnotherFile_MSM.Click += buttonSaveAnotherFile_MSM_Click;
            // 
            // buttonLoadTableClose_MSM
            // 
            buttonLoadTableClose_MSM.Font = new Font("Segoe UI", 10F);
            buttonLoadTableClose_MSM.Location = new Point(113, 12);
            buttonLoadTableClose_MSM.Name = "buttonLoadTableClose_MSM";
            buttonLoadTableClose_MSM.Size = new Size(150, 29);
            buttonLoadTableClose_MSM.TabIndex = 2;
            buttonLoadTableClose_MSM.Text = "Закрыть таблицу";
            toolTip_MSM.SetToolTip(buttonLoadTableClose_MSM, "Закрыть загруженную таблицу");
            buttonLoadTableClose_MSM.UseVisualStyleBackColor = true;
            buttonLoadTableClose_MSM.Visible = false;
            buttonLoadTableClose_MSM.Click += buttonLoadTableClose_MSM_Click;
            // 
            // buttonLoadTableSave_MSM
            // 
            buttonLoadTableSave_MSM.Font = new Font("Segoe UI", 10F);
            buttonLoadTableSave_MSM.Location = new Point(269, 12);
            buttonLoadTableSave_MSM.Name = "buttonLoadTableSave_MSM";
            buttonLoadTableSave_MSM.Size = new Size(160, 29);
            buttonLoadTableSave_MSM.TabIndex = 2;
            buttonLoadTableSave_MSM.Text = "Сохранить таблицу";
            toolTip_MSM.SetToolTip(buttonLoadTableSave_MSM, "Переместить таблицу в низ основной таблицы");
            buttonLoadTableSave_MSM.UseVisualStyleBackColor = true;
            buttonLoadTableSave_MSM.Visible = false;
            buttonLoadTableSave_MSM.Click += buttonLoadTableSave_MSM_Click;
            // 
            // buttonLoadTable_MSM
            // 
            buttonLoadTable_MSM.Font = new Font("Segoe UI", 10F);
            buttonLoadTable_MSM.Location = new Point(12, 12);
            buttonLoadTable_MSM.Name = "buttonLoadTable_MSM";
            buttonLoadTable_MSM.Size = new Size(95, 29);
            buttonLoadTable_MSM.TabIndex = 1;
            buttonLoadTable_MSM.Text = "Загрузить таблицу";
            toolTip_MSM.SetToolTip(buttonLoadTable_MSM, "Загрузка CSV файла");
            buttonLoadTable_MSM.UseVisualStyleBackColor = true;
            buttonLoadTable_MSM.Click += buttonLoadTable_MSM_Click;
            // 
            // buttonSaveTableInFile_MSM
            // 
            buttonSaveTableInFile_MSM.FlatStyle = FlatStyle.System;
            buttonSaveTableInFile_MSM.Font = new Font("Segoe UI", 10F);
            buttonSaveTableInFile_MSM.Location = new Point(12, 47);
            buttonSaveTableInFile_MSM.Name = "buttonSaveTableInFile_MSM";
            buttonSaveTableInFile_MSM.Size = new Size(95, 29);
            buttonSaveTableInFile_MSM.TabIndex = 0;
            buttonSaveTableInFile_MSM.Text = "Сохранить";
            toolTip_MSM.SetToolTip(buttonSaveTableInFile_MSM, "Сохранить основную таблицу");
            buttonSaveTableInFile_MSM.UseVisualStyleBackColor = true;
            buttonSaveTableInFile_MSM.Click += buttonSaveFileInTable_MSM_Click;
            // 
            // panelTable_MSM
            // 
            panelTable_MSM.Controls.Add(dataGridViewTable_MSM);
            panelTable_MSM.Dock = DockStyle.Fill;
            panelTable_MSM.Location = new Point(0, 119);
            panelTable_MSM.Name = "panelTable_MSM";
            panelTable_MSM.Size = new Size(284, 77);
            panelTable_MSM.TabIndex = 0;
            panelTable_MSM.Visible = false;
            // 
            // dataGridViewTable_MSM
            // 
            dataGridViewTable_MSM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTable_MSM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable_MSM.Columns.AddRange(new DataGridViewColumn[] { LastName, FirstName, Patronymic, HomeAddress, Telephone, DateOfBirth, Position, DateOfEnrollment, Salary, Education, NumberRow });
            dataGridViewTable_MSM.Dock = DockStyle.Fill;
            dataGridViewTable_MSM.Location = new Point(0, 0);
            dataGridViewTable_MSM.Name = "dataGridViewTable_MSM";
            dataGridViewTable_MSM.Size = new Size(284, 77);
            dataGridViewTable_MSM.TabIndex = 0;
            dataGridViewTable_MSM.CellValueChanged += dataGridViewTable_MSM_CellValueChanged;
            dataGridViewTable_MSM.RowsAdded += dataGridViewTable_MSM_RowsAdded;
            dataGridViewTable_MSM.UserDeletedRow += dataGridViewTable_MSM_UserDeletedRow;
            // 
            // LastName
            // 
            LastName.HeaderText = "Фамилия";
            LastName.Name = "LastName";
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Имя";
            FirstName.Name = "FirstName";
            // 
            // Patronymic
            // 
            Patronymic.HeaderText = "Отчество";
            Patronymic.Name = "Patronymic";
            // 
            // HomeAddress
            // 
            HomeAddress.HeaderText = "Домашний адрес";
            HomeAddress.Name = "HomeAddress";
            // 
            // Telephone
            // 
            Telephone.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Telephone.HeaderText = "Телефон";
            Telephone.Name = "Telephone";
            // 
            // DateOfBirth
            // 
            DateOfBirth.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DateOfBirth.HeaderText = "День рождения";
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Width = 85;
            // 
            // Position
            // 
            Position.HeaderText = "Должность";
            Position.Name = "Position";
            // 
            // DateOfEnrollment
            // 
            DateOfEnrollment.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DateOfEnrollment.HeaderText = "Дата зачисления";
            DateOfEnrollment.Name = "DateOfEnrollment";
            DateOfEnrollment.Width = 85;
            // 
            // Salary
            // 
            Salary.HeaderText = "Оклад";
            Salary.Name = "Salary";
            // 
            // Education
            // 
            Education.HeaderText = "Образование";
            Education.Name = "Education";
            // 
            // NumberRow
            // 
            NumberRow.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NumberRow.HeaderText = "Номер строки";
            NumberRow.Name = "NumberRow";
            NumberRow.ReadOnly = true;
            NumberRow.Visible = false;
            NumberRow.Width = 5;
            // 
            // panelStatistics_MSM
            // 
            panelStatistics_MSM.Controls.Add(groupBoxFilter_MSM);
            panelStatistics_MSM.Controls.Add(chartGraphic_MSM);
            panelStatistics_MSM.Controls.Add(dataGridViewFunction_MSM);
            panelStatistics_MSM.Controls.Add(comboBoxIndexStaticColumn_MSM);
            panelStatistics_MSM.Controls.Add(comboBoxIndexFilterColumn_MSM);
            panelStatistics_MSM.Dock = DockStyle.Bottom;
            panelStatistics_MSM.Location = new Point(0, 196);
            panelStatistics_MSM.Name = "panelStatistics_MSM";
            panelStatistics_MSM.Size = new Size(284, 165);
            panelStatistics_MSM.TabIndex = 1;
            panelStatistics_MSM.Visible = false;
            // 
            // groupBoxFilter_MSM
            // 
            groupBoxFilter_MSM.Controls.Add(checkedListBoxFilter_MSM);
            groupBoxFilter_MSM.Controls.Add(buttonResetFilter_MSM);
            groupBoxFilter_MSM.Controls.Add(buttonUseFilter_MSM);
            groupBoxFilter_MSM.Font = new Font("Segoe UI", 10F);
            groupBoxFilter_MSM.Location = new Point(954, 1);
            groupBoxFilter_MSM.Name = "groupBoxFilter_MSM";
            groupBoxFilter_MSM.Size = new Size(200, 164);
            groupBoxFilter_MSM.TabIndex = 21;
            groupBoxFilter_MSM.TabStop = false;
            groupBoxFilter_MSM.Text = "Фильтер";
            groupBoxFilter_MSM.Visible = false;
            // 
            // checkedListBoxFilter_MSM
            // 
            checkedListBoxFilter_MSM.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkedListBoxFilter_MSM.Font = new Font("Segoe UI", 10F);
            checkedListBoxFilter_MSM.Location = new Point(9, 24);
            checkedListBoxFilter_MSM.Name = "checkedListBoxFilter_MSM";
            checkedListBoxFilter_MSM.Size = new Size(185, 104);
            checkedListBoxFilter_MSM.TabIndex = 13;
            toolTip_MSM.SetToolTip(checkedListBoxFilter_MSM, "Настройка фильтра");
            // 
            // buttonResetFilter_MSM
            // 
            buttonResetFilter_MSM.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonResetFilter_MSM.Font = new Font("Segoe UI", 10F);
            buttonResetFilter_MSM.Location = new Point(9, 128);
            buttonResetFilter_MSM.Name = "buttonResetFilter_MSM";
            buttonResetFilter_MSM.Size = new Size(80, 29);
            buttonResetFilter_MSM.TabIndex = 18;
            buttonResetFilter_MSM.Text = "Сбросить";
            toolTip_MSM.SetToolTip(buttonResetFilter_MSM, "Сбросить фильтр");
            buttonResetFilter_MSM.UseVisualStyleBackColor = true;
            buttonResetFilter_MSM.Click += buttonResetFilter_MSM_Click;
            // 
            // buttonUseFilter_MSM
            // 
            buttonUseFilter_MSM.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUseFilter_MSM.Font = new Font("Segoe UI", 10F);
            buttonUseFilter_MSM.Location = new Point(95, 128);
            buttonUseFilter_MSM.Name = "buttonUseFilter_MSM";
            buttonUseFilter_MSM.Size = new Size(99, 29);
            buttonUseFilter_MSM.TabIndex = 18;
            buttonUseFilter_MSM.Text = "Применить";
            toolTip_MSM.SetToolTip(buttonUseFilter_MSM, "Применить фильтр");
            buttonUseFilter_MSM.UseVisualStyleBackColor = true;
            buttonUseFilter_MSM.Click += buttonUseFilter_MSM_Click;
            // 
            // chartGraphic_MSM
            // 
            chartGraphic_MSM.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartGraphic_MSM.ChartAreas.Add(chartArea1);
            legend1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartGraphic_MSM.Legends.Add(legend1);
            chartGraphic_MSM.Location = new Point(-597, 0);
            chartGraphic_MSM.Name = "chartGraphic_MSM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGraphic_MSM.Series.Add(series1);
            chartGraphic_MSM.Size = new Size(433, 159);
            chartGraphic_MSM.TabIndex = 20;
            chartGraphic_MSM.Text = "chart1";
            toolTip_MSM.SetToolTip(chartGraphic_MSM, "График по выбранному столбцу");
            chartGraphic_MSM.Visible = false;
            // 
            // dataGridViewFunction_MSM
            // 
            dataGridViewFunction_MSM.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewFunction_MSM.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewFunction_MSM.BackgroundColor = SystemColors.Control;
            dataGridViewFunction_MSM.BorderStyle = BorderStyle.None;
            dataGridViewFunction_MSM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_MSM.Columns.AddRange(new DataGridViewColumn[] { Function, Result });
            dataGridViewFunction_MSM.Location = new Point(-158, 0);
            dataGridViewFunction_MSM.Name = "dataGridViewFunction_MSM";
            dataGridViewFunction_MSM.RowHeadersVisible = false;
            dataGridViewFunction_MSM.RowTemplate.ReadOnly = true;
            dataGridViewFunction_MSM.ScrollBars = ScrollBars.None;
            dataGridViewFunction_MSM.Size = new Size(240, 188);
            dataGridViewFunction_MSM.TabIndex = 17;
            toolTip_MSM.SetToolTip(dataGridViewFunction_MSM, "Статистика выбранного столбца");
            dataGridViewFunction_MSM.Visible = false;
            // 
            // Function
            // 
            Function.HeaderText = "Функция";
            Function.Name = "Function";
            Function.ReadOnly = true;
            // 
            // Result
            // 
            Result.HeaderText = "Значение";
            Result.Name = "Result";
            Result.ReadOnly = true;
            // 
            // comboBoxIndexStaticColumn_MSM
            // 
            comboBoxIndexStaticColumn_MSM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxIndexStaticColumn_MSM.Font = new Font("Segoe UI", 10F);
            comboBoxIndexStaticColumn_MSM.FormattingEnabled = true;
            comboBoxIndexStaticColumn_MSM.Items.AddRange(new object[] { "Фамилия", "Имя", "Отчество", "Домашний адрес", "Телефон", "День рождения", "Должность", "Дата зачисления", "Оклад", "Образование" });
            comboBoxIndexStaticColumn_MSM.Location = new Point(12, 89);
            comboBoxIndexStaticColumn_MSM.Name = "comboBoxIndexStaticColumn_MSM";
            comboBoxIndexStaticColumn_MSM.Size = new Size(121, 25);
            comboBoxIndexStaticColumn_MSM.TabIndex = 15;
            toolTip_MSM.SetToolTip(comboBoxIndexStaticColumn_MSM, "Выбор столбца для статистики");
            comboBoxIndexStaticColumn_MSM.TextChanged += comboBoxIndexStaticColumn_MSM_TextChanged;
            comboBoxIndexStaticColumn_MSM.KeyPress += comboBoxIndexFilterColumn_MSM_KeyPress;
            // 
            // comboBoxIndexFilterColumn_MSM
            // 
            comboBoxIndexFilterColumn_MSM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxIndexFilterColumn_MSM.Font = new Font("Segoe UI", 10F);
            comboBoxIndexFilterColumn_MSM.FormattingEnabled = true;
            comboBoxIndexFilterColumn_MSM.Items.AddRange(new object[] { "Фамилия", "Имя", "Отчество", "Домашний адрес", "Телефон", "День рождения", "Должность", "Дата зачисления", "Оклад", "Образование" });
            comboBoxIndexFilterColumn_MSM.Location = new Point(12, 120);
            comboBoxIndexFilterColumn_MSM.Name = "comboBoxIndexFilterColumn_MSM";
            comboBoxIndexFilterColumn_MSM.Size = new Size(121, 25);
            comboBoxIndexFilterColumn_MSM.TabIndex = 15;
            toolTip_MSM.SetToolTip(comboBoxIndexFilterColumn_MSM, "Выбор столбца для фильтра");
            comboBoxIndexFilterColumn_MSM.TextChanged += comboBoxIndexFilterColumn_MSM_TextChanged;
            comboBoxIndexFilterColumn_MSM.KeyPress += comboBoxIndexFilterColumn_MSM_KeyPress;
            // 
            // buttonMain_MSM
            // 
            buttonMain_MSM.Font = new Font("Segoe UI", 16F);
            buttonMain_MSM.Location = new Point(37, 109);
            buttonMain_MSM.Name = "buttonMain_MSM";
            buttonMain_MSM.Size = new Size(210, 70);
            buttonMain_MSM.TabIndex = 2;
            buttonMain_MSM.Text = "Таблица";
            toolTip_MSM.SetToolTip(buttonMain_MSM, "Открывает рабочее пространство");
            buttonMain_MSM.UseVisualStyleBackColor = true;
            buttonMain_MSM.Click += buttonMain_MSM_Click;
            // 
            // buttonManual_MSM
            // 
            buttonManual_MSM.Font = new Font("Segoe UI", 16F);
            buttonManual_MSM.Location = new Point(37, 185);
            buttonManual_MSM.Name = "buttonManual_MSM";
            buttonManual_MSM.Size = new Size(210, 70);
            buttonManual_MSM.TabIndex = 2;
            buttonManual_MSM.Text = "Руководство";
            toolTip_MSM.SetToolTip(buttonManual_MSM, "Открывает руководство по приложению");
            buttonManual_MSM.UseVisualStyleBackColor = true;
            buttonManual_MSM.Click += buttonManual_MSM_Click;
            // 
            // buttonAboutProgram_MSM
            // 
            buttonAboutProgram_MSM.Font = new Font("Segoe UI", 16F);
            buttonAboutProgram_MSM.Location = new Point(37, 261);
            buttonAboutProgram_MSM.Name = "buttonAboutProgram_MSM";
            buttonAboutProgram_MSM.Size = new Size(210, 70);
            buttonAboutProgram_MSM.TabIndex = 2;
            buttonAboutProgram_MSM.Text = "О приложении";
            toolTip_MSM.SetToolTip(buttonAboutProgram_MSM, "Об авторе приложения");
            buttonAboutProgram_MSM.UseVisualStyleBackColor = true;
            buttonAboutProgram_MSM.Click += buttonAboutProgram_MSM_Click;
            // 
            // textBoxInform_MSM
            // 
            textBoxInform_MSM.BackColor = SystemColors.Control;
            textBoxInform_MSM.BorderStyle = BorderStyle.None;
            textBoxInform_MSM.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxInform_MSM.Location = new Point(37, 46);
            textBoxInform_MSM.Multiline = true;
            textBoxInform_MSM.Name = "textBoxInform_MSM";
            textBoxInform_MSM.ReadOnly = true;
            textBoxInform_MSM.Size = new Size(210, 57);
            textBoxInform_MSM.TabIndex = 3;
            textBoxInform_MSM.Text = "Приложение для отдела кадров";
            textBoxInform_MSM.TextAlign = HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(textBoxInform_MSM);
            Controls.Add(buttonAboutProgram_MSM);
            Controls.Add(buttonManual_MSM);
            Controls.Add(buttonMain_MSM);
            Controls.Add(panelTable_MSM);
            Controls.Add(panelStatistics_MSM);
            Controls.Add(panelMenu_MSM);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(284, 361);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отдел кадров";
            panelMenu_MSM.ResumeLayout(false);
            groupBoxSearch_MSM.ResumeLayout(false);
            groupBoxSearch_MSM.PerformLayout();
            panelTable_MSM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_MSM).EndInit();
            panelStatistics_MSM.ResumeLayout(false);
            groupBoxFilter_MSM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGraphic_MSM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_MSM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu_MSM;
        private Panel panelTable_MSM;
        private DataGridView dataGridViewTable_MSM;
        private Button buttonSaveTableInFile_MSM;
        private Button buttonLoadTable_MSM;
        private OpenFileDialog openFileDialog_MSM;
        private Button buttonLoadTableClose_MSM;
        private Button buttonLoadTableSave_MSM;
        private Panel panelStatistics_MSM;
        private Button buttonSaveAnotherFile_MSM;
        private SaveFileDialog saveFileDialog_MSM;
        private Button buttonMenu_MSM;
        private GroupBox groupBoxSearch_MSM;
        private TextBox textBoxSearch_MSM;
        private Button buttonSearch_MSM;
        private CheckedListBox checkedListBoxFilter_MSM;
        private ComboBox comboBoxIndexFilterColumn_MSM;
        private DataGridView dataGridViewFunction_MSM;
        private DataGridViewTextBoxColumn Function;
        private DataGridViewTextBoxColumn Result;
        private Button buttonResetFilter_MSM;
        private Button buttonUseFilter_MSM;
        private Button buttonResetTable_MSM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphic_MSM;
        private ToolTip toolTip_MSM;
        private GroupBox groupBoxFilter_MSM;
        private Button buttonMain_MSM;
        private Button buttonManual_MSM;
        private Button buttonAboutProgram_MSM;
        private TextBox textBoxInform_MSM;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Patronymic;
        private DataGridViewTextBoxColumn HomeAddress;
        private DataGridViewTextBoxColumn Telephone;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn DateOfEnrollment;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn Education;
        private DataGridViewTextBoxColumn NumberRow;
        private ComboBox comboBoxIndexStaticColumn_MSM;
    }
}
