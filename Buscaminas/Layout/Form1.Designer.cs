namespace Buscaminas
{
    partial class Main
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
            play = new Button();
            easy = new RadioButton();
            medium = new RadioButton();
            hard = new RadioButton();
            custom = new RadioButton();
            SuspendLayout();
            // 
            // play
            // 
            play.Location = new Point(326, 208);
            play.Name = "play";
            play.Size = new Size(149, 23);
            play.TabIndex = 1;
            play.Text = "Play";
            play.UseVisualStyleBackColor = true;
            play.Click += play_Click;
            // 
            // easy
            // 
            easy.AutoSize = true;
            easy.Checked = true;
            easy.Location = new Point(143, 137);
            easy.Name = "easy";
            easy.Size = new Size(89, 19);
            easy.TabIndex = 2;
            easy.TabStop = true;
            easy.Text = "Easy (20x20)";
            easy.UseVisualStyleBackColor = true;
            // 
            // medium
            // 
            medium.AutoSize = true;
            medium.Location = new Point(284, 137);
            medium.Name = "medium";
            medium.Size = new Size(111, 19);
            medium.TabIndex = 3;
            medium.Text = "Medium (25x25)";
            medium.UseVisualStyleBackColor = true;
            medium.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // hard
            // 
            hard.AutoSize = true;
            hard.Location = new Point(447, 137);
            hard.Name = "hard";
            hard.Size = new Size(92, 19);
            hard.TabIndex = 4;
            hard.Text = "Hard (30x30)";
            hard.TextAlign = ContentAlignment.MiddleCenter;
            hard.UseVisualStyleBackColor = true;
            // 
            // custom
            // 
            custom.AutoSize = true;
            custom.Location = new Point(591, 138);
            custom.Name = "custom";
            custom.Size = new Size(67, 19);
            custom.TabIndex = 5;
            custom.TabStop = true;
            custom.Text = "Custom";
            custom.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(custom);
            Controls.Add(hard);
            Controls.Add(medium);
            Controls.Add(easy);
            Controls.Add(play);
            Name = "Main";
            Text = "Buscaminas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button play;
        private RadioButton easy;
        private RadioButton medium;
        private RadioButton hard;
        private RadioButton custom;
    }
}