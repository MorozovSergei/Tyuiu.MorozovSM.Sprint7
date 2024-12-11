namespace Tyuiu.MorozovSM.Sprint7.Project.V11
{
    partial class FormManual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual));
            tabControlText_MSM = new TabControl();
            UpLeft = new TabPage();
            textBoxUpLeft_MSM = new TextBox();
            UpRight = new TabPage();
            textBoxUpRight_MSM = new TextBox();
            Down = new TabPage();
            textBoxDown_MSM = new TextBox();
            Centre = new TabPage();
            textBoxCentre_MSM = new TextBox();
            buttonClose_MSM = new Button();
            tabControlText_MSM.SuspendLayout();
            UpLeft.SuspendLayout();
            UpRight.SuspendLayout();
            Down.SuspendLayout();
            Centre.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlText_MSM
            // 
            tabControlText_MSM.Controls.Add(UpLeft);
            tabControlText_MSM.Controls.Add(UpRight);
            tabControlText_MSM.Controls.Add(Down);
            tabControlText_MSM.Controls.Add(Centre);
            tabControlText_MSM.Location = new Point(12, 12);
            tabControlText_MSM.Name = "tabControlText_MSM";
            tabControlText_MSM.SelectedIndex = 0;
            tabControlText_MSM.Size = new Size(398, 309);
            tabControlText_MSM.TabIndex = 0;
            // 
            // UpLeft
            // 
            UpLeft.Controls.Add(textBoxUpLeft_MSM);
            UpLeft.Location = new Point(4, 26);
            UpLeft.Name = "UpLeft";
            UpLeft.Padding = new Padding(3);
            UpLeft.Size = new Size(390, 279);
            UpLeft.TabIndex = 0;
            UpLeft.Text = "Верхний левый угол";
            UpLeft.UseVisualStyleBackColor = true;
            // 
            // textBoxUpLeft_MSM
            // 
            textBoxUpLeft_MSM.Location = new Point(6, 6);
            textBoxUpLeft_MSM.Multiline = true;
            textBoxUpLeft_MSM.Name = "textBoxUpLeft_MSM";
            textBoxUpLeft_MSM.Size = new Size(378, 267);
            textBoxUpLeft_MSM.TabIndex = 0;
            textBoxUpLeft_MSM.Text = resources.GetString("textBoxUpLeft_MSM.Text");
            // 
            // UpRight
            // 
            UpRight.Controls.Add(textBoxUpRight_MSM);
            UpRight.Location = new Point(4, 24);
            UpRight.Name = "UpRight";
            UpRight.Padding = new Padding(3);
            UpRight.Size = new Size(390, 281);
            UpRight.TabIndex = 1;
            UpRight.Text = "Верхний правый угол";
            UpRight.UseVisualStyleBackColor = true;
            // 
            // textBoxUpRight_MSM
            // 
            textBoxUpRight_MSM.Location = new Point(6, 6);
            textBoxUpRight_MSM.Multiline = true;
            textBoxUpRight_MSM.Name = "textBoxUpRight_MSM";
            textBoxUpRight_MSM.Size = new Size(378, 267);
            textBoxUpRight_MSM.TabIndex = 0;
            textBoxUpRight_MSM.Text = resources.GetString("textBoxUpRight_MSM.Text");
            // 
            // Down
            // 
            Down.Controls.Add(textBoxDown_MSM);
            Down.Location = new Point(4, 24);
            Down.Name = "Down";
            Down.Size = new Size(390, 281);
            Down.TabIndex = 2;
            Down.Text = "Низ";
            Down.UseVisualStyleBackColor = true;
            // 
            // textBoxDown_MSM
            // 
            textBoxDown_MSM.Location = new Point(6, 6);
            textBoxDown_MSM.Multiline = true;
            textBoxDown_MSM.Name = "textBoxDown_MSM";
            textBoxDown_MSM.Size = new Size(378, 267);
            textBoxDown_MSM.TabIndex = 0;
            textBoxDown_MSM.Text = resources.GetString("textBoxDown_MSM.Text");
            // 
            // Centre
            // 
            Centre.Controls.Add(textBoxCentre_MSM);
            Centre.Location = new Point(4, 24);
            Centre.Name = "Centre";
            Centre.Size = new Size(390, 281);
            Centre.TabIndex = 3;
            Centre.Text = "Центр";
            Centre.UseVisualStyleBackColor = true;
            // 
            // textBoxCentre_MSM
            // 
            textBoxCentre_MSM.Location = new Point(6, 6);
            textBoxCentre_MSM.Multiline = true;
            textBoxCentre_MSM.Name = "textBoxCentre_MSM";
            textBoxCentre_MSM.Size = new Size(378, 267);
            textBoxCentre_MSM.TabIndex = 0;
            textBoxCentre_MSM.Text = "В центре расположена таблица.\r\nПри нажании на столбец начинается сортировка по столбцу.\r\nПри нажатии на строку и нажатии кнопки \"DEL\", строка удаляется.";
            // 
            // buttonClose_MSM
            // 
            buttonClose_MSM.Location = new Point(335, 327);
            buttonClose_MSM.Name = "buttonClose_MSM";
            buttonClose_MSM.Size = new Size(75, 26);
            buttonClose_MSM.TabIndex = 1;
            buttonClose_MSM.Text = "Ок";
            buttonClose_MSM.UseVisualStyleBackColor = true;
            buttonClose_MSM.Click += buttonClose_MSM_Click;
            // 
            // FormManual
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 361);
            Controls.Add(buttonClose_MSM);
            Controls.Add(tabControlText_MSM);
            Font = new Font("Segoe UI", 10F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormManual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormManual";
            tabControlText_MSM.ResumeLayout(false);
            UpLeft.ResumeLayout(false);
            UpLeft.PerformLayout();
            UpRight.ResumeLayout(false);
            UpRight.PerformLayout();
            Down.ResumeLayout(false);
            Down.PerformLayout();
            Centre.ResumeLayout(false);
            Centre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlText_MSM;
        private TabPage UpLeft;
        private TabPage UpRight;
        private TabPage Down;
        private TabPage Centre;
        private TextBox textBoxUpLeft_MSM;
        private TextBox textBoxUpRight_MSM;
        private TextBox textBoxDown_MSM;
        private TextBox textBoxCentre_MSM;
        private Button buttonClose_MSM;
    }
}