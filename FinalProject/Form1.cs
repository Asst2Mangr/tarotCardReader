using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

// Reaenn Wiebers
// 11/9/22
// This program will pick either one, three, or six random Tarot cards for the user. The names of the cards are put into a file,
// read from the file, and then placed into the label.

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StreamWriter outputFile;
        StreamReader inputFile;

        private void oneCardBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int cardIndex = random.Next(imageList.Images.Count);
            pictureBox1.Image = imageList.Images[cardIndex];

            try
            {
                outputFile = File.CreateText("CardNames.txt");
                for(int i =0; i < 1; i++) 
                {
                    outputFile.WriteLine(imageList.Images.Keys[cardIndex]);
                }
                outputFile.Close();

                inputFile = File.OpenText("CardNames.txt");
                label1.Text = inputFile.ReadLine();
                inputFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    
        }

        private void threeCardBtn_Click(object sender, EventArgs e)
        {
            Random random1 = new Random();
            int index1 = random1.Next(imageList.Images.Count);
            pictureBox1.Image = imageList.Images[index1];

            Random random2 = new Random();
            int index2 = random2.Next(imageList.Images.Count);
            pictureBox2.Image = imageList.Images[index2];

            Random random3 = new Random();
            int index3 = random3.Next(imageList.Images.Count);
            pictureBox3.Image = imageList.Images[index3];


            try
            {
                outputFile = File.CreateText("CardNames.txt");
                for (int i = 0; i < 3; i++)
                {
                    outputFile.WriteLine(imageList.Images.Keys[index1]);
                    outputFile.WriteLine(imageList.Images.Keys[index2]);
                    outputFile.WriteLine(imageList.Images.Keys[index3]);
                }
                outputFile.Close();

                inputFile = File.OpenText("CardNames.txt");
                label1.Text = inputFile.ReadLine();
                label2.Text = inputFile.ReadLine();
                label3.Text = inputFile.ReadLine(); 
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sixCardBtn_Click(object sender, EventArgs e)
        {
            Random random1 = new Random();
            int index1 = random1.Next(imageList.Images.Count);
            pictureBox1.Image = imageList.Images[index1];

            Random random2 = new Random();
            int index2 = random2.Next(imageList.Images.Count);
            pictureBox2.Image = imageList.Images[index2];

            Random random3 = new Random();
            int index3 = random3.Next(imageList.Images.Count);
            pictureBox3.Image = imageList.Images[index3];

            Random random4 = new Random();
            int index4 = random4.Next(imageList.Images.Count);
            pictureBox4.Image = imageList.Images[index4];

            Random random5 = new Random();
            int index5 = random5.Next(imageList.Images.Count);
            pictureBox5.Image = imageList.Images[index5];

            Random random6 = new Random();
            int index6 = random6.Next(imageList.Images.Count);
            pictureBox6.Image = imageList.Images[index6];


            try
            {
                outputFile = File.CreateText("CardNames.txt");
                for (int i = 0; i < 6; i++)
                {
                    outputFile.WriteLine(imageList.Images.Keys[index1]);
                    outputFile.WriteLine(imageList.Images.Keys[index2]);
                    outputFile.WriteLine(imageList.Images.Keys[index3]);
                    outputFile.WriteLine(imageList.Images.Keys[index4]);
                    outputFile.WriteLine(imageList.Images.Keys[index5]);
                    outputFile.WriteLine(imageList.Images.Keys[index6]);
                }
                outputFile.Close();

                inputFile = File.OpenText("CardNames.txt");
                label1.Text = inputFile.ReadLine();
                label2.Text = inputFile.ReadLine();
                label3.Text = inputFile.ReadLine();
                label4.Text = inputFile.ReadLine();
                label5.Text = inputFile.ReadLine();
                label6.Text = inputFile.ReadLine();
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clearCards_Click(object sender, EventArgs e)
        {
            pictureBox1.Image= null;
            pictureBox2.Image= null;    
            pictureBox3.Image= null;    
            pictureBox4.Image= null;
            pictureBox5.Image= null;
            pictureBox6.Image= null;

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
