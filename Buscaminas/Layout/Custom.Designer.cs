namespace Buscaminas.Layout
{
    partial class Custom
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
            numericUpDown1 = new NumericUpDown();
            rows = new Label();
            columns = new Label();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(148, 25);
            numericUpDown1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(49, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // rows
            // 
            rows.AutoSize = true;
            rows.Location = new Point(40, 27);
            rows.Name = "rows";
            rows.Size = new Size(69, 15);
            rows.TabIndex = 1;
            rows.Text = "Rows (4-50)";
            // 
            // columns
            // 
            columns.AutoSize = true;
            columns.Location = new Point(40, 62);
            columns.Name = "columns";
            columns.Size = new Size(89, 15);
            columns.TabIndex = 2;
            columns.Text = "Columns (4-50)";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(148, 60);
            numericUpDown2.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(49, 23);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // Custom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 168);
            Controls.Add(numericUpDown2);
            Controls.Add(columns);
            Controls.Add(rows);
            Controls.Add(numericUpDown1);
            Name = "Custom";
            Text = "Custom mode";
            Load += Custom_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label rows;
        private Label columns;
        private NumericUpDown numericUpDown2;
    }
}