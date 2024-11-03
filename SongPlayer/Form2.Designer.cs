namespace SongPlayer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Continue = new System.Windows.Forms.Button();
            this.Save1Text = new System.Windows.Forms.TextBox();
            this.Save2Text = new System.Windows.Forms.TextBox();
            this.Save3Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.Continue2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(12, 122);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(75, 23);
            this.Continue.TabIndex = 3;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Save1Text
            // 
            this.Save1Text.Location = new System.Drawing.Point(12, 50);
            this.Save1Text.Name = "Save1Text";
            this.Save1Text.Size = new System.Drawing.Size(100, 20);
            this.Save1Text.TabIndex = 4;
            this.Save1Text.TextChanged += new System.EventHandler(this.Save1Text_TextChanged);
            // 
            // Save2Text
            // 
            this.Save2Text.Location = new System.Drawing.Point(153, 50);
            this.Save2Text.Name = "Save2Text";
            this.Save2Text.Size = new System.Drawing.Size(100, 20);
            this.Save2Text.TabIndex = 5;
            this.Save2Text.TextChanged += new System.EventHandler(this.Save2Text_TextChanged);
            // 
            // Save3Text
            // 
            this.Save3Text.Location = new System.Drawing.Point(84, 96);
            this.Save3Text.Name = "Save3Text";
            this.Save3Text.Size = new System.Drawing.Size(100, 20);
            this.Save3Text.TabIndex = 6;
            this.Save3Text.TextChanged += new System.EventHandler(this.Save3Text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Two";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Three";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 139);
            this.label4.TabIndex = 10;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, -9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 56);
            this.label5.TabIndex = 11;
            this.label5.Text = "Copy and paste a file directory in each box to store the save files in";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(178, 122);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 12;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Continue2
            // 
            this.Continue2.Location = new System.Drawing.Point(93, 122);
            this.Continue2.Name = "Continue2";
            this.Continue2.Size = new System.Drawing.Size(75, 23);
            this.Continue2.TabIndex = 13;
            this.Continue2.Text = "Continue";
            this.Continue2.UseVisualStyleBackColor = true;
            this.Continue2.Visible = false;
            this.Continue2.Click += new System.EventHandler(this.Continue2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(269, 271);
            this.Controls.Add(this.Continue2);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save3Text);
            this.Controls.Add(this.Save2Text);
            this.Controls.Add(this.Save1Text);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.TextBox Save1Text;
        private System.Windows.Forms.TextBox Save2Text;
        private System.Windows.Forms.TextBox Save3Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Continue2;
    }
}