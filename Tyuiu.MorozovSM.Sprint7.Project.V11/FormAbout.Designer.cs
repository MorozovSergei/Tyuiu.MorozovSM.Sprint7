namespace Tyuiu.MorozovSM.Sprint7.Project.V11
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBoxInformation_MSM = new TextBox();
            buttonClose_MSM = new Button();
            SuspendLayout();
            // 
            // textBoxInformation_MSM
            // 
            textBoxInformation_MSM.Location = new Point(12, 12);
            textBoxInformation_MSM.Multiline = true;
            textBoxInformation_MSM.Name = "textBoxInformation_MSM";
            textBoxInformation_MSM.ReadOnly = true;
            textBoxInformation_MSM.Size = new Size(230, 226);
            textBoxInformation_MSM.TabIndex = 0;
            textBoxInformation_MSM.Text = resources.GetString("textBoxInformation_MSM.Text");
            // 
            // buttonClose_MSM
            // 
            buttonClose_MSM.Location = new Point(167, 244);
            buttonClose_MSM.Name = "buttonClose_MSM";
            buttonClose_MSM.Size = new Size(75, 26);
            buttonClose_MSM.TabIndex = 1;
            buttonClose_MSM.Text = "Ок";
            buttonClose_MSM.UseVisualStyleBackColor = true;
            buttonClose_MSM.Click += buttonClose_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 281);
            Controls.Add(buttonClose_MSM);
            Controls.Add(textBoxInformation_MSM);
            Font = new Font("Segoe UI", 10F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInformation_MSM;
        private Button buttonClose_MSM;
    }
}