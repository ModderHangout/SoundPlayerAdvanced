using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SongPlayer
{
    public partial class Form2 : Form
    {
        public static Form2 instance;

        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        public string Save1L;
        public string Save2L;
        public string Save3L;

        
        //dont use
        private void One_Click(object sender, EventArgs e)
        {

        }

        private void Two_Click(object sender, EventArgs e)
        {

        }

        private void Three_Click(object sender, EventArgs e)
        {

        }

        //end

        private void Continue_Click(object sender, EventArgs e)
        {

                Form1 form1 = new Form1();
                form1.Show();

                Form1.instance.SSave1 = Save1L;
                Form1.instance.SSave2 = Save2L;
                Form1.instance.SSave3 = Save3L;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if (File.Exists("D:\\SongPlayerMain.txt"))
            {
                using (StreamReader Reader = new StreamReader("D:\\SongPlayerMain.txt"))
                {
                    Reader.ReadLine();
                    string HaveBeenBefor;
                    HaveBeenBefor = Reader.ReadLine();
                    if(HaveBeenBefor == "True")
                    {
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false; 
                        label4.Visible = false;
                        label5.Visible = false;

                        Save1Text.Visible = false;
                        Save2Text.Visible = false;
                        Save3Text.Visible = false;
                        Create.Visible = false;
                        Continue.Visible = false;
                        Continue2.Visible = true;
                    }
                }
            }



            if(File.Exists("D:\\SaveLocations.txt") == false)
            {
                File.Create("D:\\SaveLocations.txt");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Save1Text_TextChanged(object sender, EventArgs e)
        {
            Save1L = Save1Text.Text;
        }

        private void Save2Text_TextChanged(object sender, EventArgs e)
        {
            Save2L = Save2Text.Text;
        }

        private void Save3Text_TextChanged(object sender, EventArgs e)
        {
            Save3L = Save3Text.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void Create_Click(object sender, EventArgs e)
        {
            using (StreamWriter Writer = new StreamWriter("D:\\SaveLocations.txt"))
            {
                File.Create(Save1L + "\\SongSave1.txt");
                File.Create(Save2L + "\\SongSave2.txt");
                File.Create(Save3L + "\\SongSave3.txt");

                Writer.WriteLine(Save1L + "\\SongSave1.txt");
                Writer.WriteLine(Save2L + "\\SongSave2.txt");
                Writer.WriteLine(Save3L + "\\SongSave3.txt");

                Continue.Visible = true;
                Create.Visible = false;
            }
        }

        private void Continue2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            Form1.instance.SSave1 = Save1L;
            Form1.instance.SSave2 = Save2L;
            Form1.instance.SSave3 = Save3L;
        }
    }
}
