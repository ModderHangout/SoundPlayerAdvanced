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
using System.Media;
using static System.Windows.Forms.AxHost;
using System.Collections;
using System.Threading;

namespace SongPlayer
{
    public partial class Form1 : Form
    {


        public bool looped;
        public static Form1 instance;


        public string SSave1;
        public string SSave2;
        public string SSave3;

        SoundPlayer player;
        public Form1()
        {
            InitializeComponent();

            instance = this;


            if (File.Exists("D:\\SongPlayerMain.txt") == false)
            {
                File.Create("D:\\SongPlayerMain.txt");
            }

            player = new SoundPlayer();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if(looped == false)
            {
                player.SoundLocation = Directory.Text;
                player.Load();
                player.PlayLooping();
            }
            else
            {
                player.SoundLocation = Directory.Text;
                player.Load();
                player.Play();
            }
        }





        //Saves
        private void Save1_Click(object sender, EventArgs e)
        {
            using (StreamReader Reader = new StreamReader("D:\\SaveLocations.txt"))
            {
                SSave1 = Reader.ReadLine();
                using(StreamWriter Writer = new StreamWriter(SSave1))
                {
                    Writer.WriteLine(Directory.Text);
                }
            }
        }

        private void Save2_Click(object sender, EventArgs e)
        {
            using (StreamReader Reader = new StreamReader("D:\\SaveLocations.txt"))
            {
                Reader.ReadLine();
                SSave2 = Reader.ReadLine();
                using (StreamWriter Writer = new StreamWriter(SSave2))
                {
                    Writer.WriteLine(Directory.Text);
                }
            }
        }

        private void Save3_Click(object sender, EventArgs e)
        {
            using (StreamReader Reader = new StreamReader("D:\\SaveLocations.txt"))
            {
                Reader.ReadLine();
                Reader.ReadLine();
                SSave3 = Reader.ReadLine();
                using (StreamWriter Writer = new StreamWriter(SSave3))
                {
                    Writer.WriteLine(Directory.Text);
                }
            }
        }



        //Load
        private void Load1_Click(object sender, EventArgs e)
        {
            using (StreamReader Reader = new StreamReader("D:\\SaveLocations.txt"))
            {
                SSave1 = Reader.ReadLine();

                using (StreamReader Reader2 = new StreamReader(SSave1))
                {
                   string D = Reader2.ReadLine();
                   Directory.Text = D;
                }
            }
        }

        private void Load2_Click(object sender, EventArgs e)
        {
            using (StreamReader Reader = new StreamReader("D:\\SaveLocations.txt"))
            {
                Reader.ReadLine();
                SSave2 = Reader.ReadLine();

                using (StreamReader Reader2 = new StreamReader(SSave2))
                {
                    string D = Reader2.ReadLine();
                    Directory.Text = D;
                }
            }
        }

        private void Load3_Click(object sender, EventArgs e)
        {
            using (StreamReader Reader = new StreamReader("D:\\SaveLocations.txt"))
            {
                Reader.ReadLine();
                Reader.ReadLine();
                SSave3 = Reader.ReadLine();

                using (StreamReader Reader2 = new StreamReader(SSave3))
                {
                    string D = Reader2.ReadLine();
                    Directory.Text = D;
                }
            }
        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (StreamWriter Writer = new StreamWriter("D:\\SongPlayerMain.txt"))
            {
                if(looped == true)
                {
                    Writer.WriteLine("True");
                    Writer.WriteLine("True");
                }

                if (looped == false)
                {
                    Writer.WriteLine("False");
                    Writer.WriteLine("True");
                }
            }
        }

        private void Looped_CheckedChanged(object sender, EventArgs e)
        {
            if (Looped.Checked == true)
            {
               looped = true;
            }

            if (Looped.Checked == false)
            {
                looped = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (StreamReader Reader = new StreamReader("D:\\SongPlayerMain.txt"))
            {
                Reader.ReadLine();
                String g = Reader.ReadLine();

                if(g == "False")
                {
                    using (StreamWriter Writer = new StreamWriter("D:\\SongPlayerMain.txt"))
                    {
                        Writer.WriteLine("False");
                        Writer.WriteLine("True");
                    }
                }
            }






            using (StreamReader Reader = new StreamReader("D:\\SongPlayerMain.txt"))
            {
                string loopedFile = Reader.ReadLine();

                if(loopedFile == "True")
                {
                    Looped.Checked = true;
                    looped = true;
                }

                if (loopedFile == "False")
                {
                    Looped.Checked = false;
                    looped = false;
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            player.Stop();
            Directory.Text = "";
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.Filter = ".wav|";
            if(browse.ShowDialog() == DialogResult.OK)
            {
                Directory.Text = browse.InitialDirectory;
            }
        }
    }
}
