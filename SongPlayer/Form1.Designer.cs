namespace SongPlayer
{
    partial class Form1
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
            this.Play = new System.Windows.Forms.Button();
            this.Directory = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.Save1 = new System.Windows.Forms.Button();
            this.Load1 = new System.Windows.Forms.Button();
            this.Load2 = new System.Windows.Forms.Button();
            this.Save2 = new System.Windows.Forms.Button();
            this.Load3 = new System.Windows.Forms.Button();
            this.Save3 = new System.Windows.Forms.Button();
            this.Looped = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(58, 53);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 0;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Directory
            // 
            this.Directory.Location = new System.Drawing.Point(43, 27);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(293, 20);
            this.Directory.TabIndex = 1;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(150, 53);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(243, 53);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 3;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Save1
            // 
            this.Save1.Location = new System.Drawing.Point(57, 122);
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(75, 23);
            this.Save1.TabIndex = 5;
            this.Save1.Text = "Save";
            this.Save1.UseVisualStyleBackColor = true;
            this.Save1.Click += new System.EventHandler(this.Save1_Click);
            // 
            // Load1
            // 
            this.Load1.Location = new System.Drawing.Point(57, 168);
            this.Load1.Name = "Load1";
            this.Load1.Size = new System.Drawing.Size(75, 23);
            this.Load1.TabIndex = 6;
            this.Load1.Text = "Load";
            this.Load1.UseVisualStyleBackColor = true;
            this.Load1.Click += new System.EventHandler(this.Load1_Click);
            // 
            // Load2
            // 
            this.Load2.Location = new System.Drawing.Point(150, 168);
            this.Load2.Name = "Load2";
            this.Load2.Size = new System.Drawing.Size(75, 23);
            this.Load2.TabIndex = 8;
            this.Load2.Text = "Load";
            this.Load2.UseVisualStyleBackColor = true;
            this.Load2.Click += new System.EventHandler(this.Load2_Click);
            // 
            // Save2
            // 
            this.Save2.Location = new System.Drawing.Point(150, 122);
            this.Save2.Name = "Save2";
            this.Save2.Size = new System.Drawing.Size(75, 23);
            this.Save2.TabIndex = 7;
            this.Save2.Text = "Save";
            this.Save2.UseVisualStyleBackColor = true;
            this.Save2.Click += new System.EventHandler(this.Save2_Click);
            // 
            // Load3
            // 
            this.Load3.Location = new System.Drawing.Point(242, 168);
            this.Load3.Name = "Load3";
            this.Load3.Size = new System.Drawing.Size(75, 23);
            this.Load3.TabIndex = 10;
            this.Load3.Text = "Load";
            this.Load3.UseVisualStyleBackColor = true;
            this.Load3.Click += new System.EventHandler(this.Load3_Click);
            // 
            // Save3
            // 
            this.Save3.Location = new System.Drawing.Point(242, 122);
            this.Save3.Name = "Save3";
            this.Save3.Size = new System.Drawing.Size(75, 23);
            this.Save3.TabIndex = 9;
            this.Save3.Text = "Save";
            this.Save3.UseVisualStyleBackColor = true;
            this.Save3.Click += new System.EventHandler(this.Save3_Click);
            // 
            // Looped
            // 
            this.Looped.AutoSize = true;
            this.Looped.Location = new System.Drawing.Point(150, 82);
            this.Looped.Name = "Looped";
            this.Looped.Size = new System.Drawing.Size(62, 17);
            this.Looped.TabIndex = 11;
            this.Looped.Text = "Looped";
            this.Looped.UseVisualStyleBackColor = true;
            this.Looped.CheckedChanged += new System.EventHandler(this.Looped_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(377, 219);
            this.Controls.Add(this.Looped);
            this.Controls.Add(this.Load3);
            this.Controls.Add(this.Save3);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Load2);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Save2);
            this.Controls.Add(this.Load1);
            this.Controls.Add(this.Directory);
            this.Controls.Add(this.Save1);
            this.Controls.Add(this.Play);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.TextBox Directory;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Load1;
        private System.Windows.Forms.Button Save1;
        private System.Windows.Forms.Button Load2;
        private System.Windows.Forms.Button Save2;
        private System.Windows.Forms.Button Load3;
        private System.Windows.Forms.Button Save3;
        private System.Windows.Forms.CheckBox Looped;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

