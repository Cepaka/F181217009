using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace Interface
{
    public partial class Form1 : Form
    {
        string path = "1";
        string dirPath = "1";
        string FilePath = "1";
        public Form1()
        {
            InitializeComponent();


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int arrsize = 0;
            int minValue = 0;
            int maxValue = 0;

            if (FilePath != "1")
            {
                if (int.TryParse(textBox2.Text, out arrsize) && int.TryParse(textBox3.Text, out minValue) && int.TryParse(textBox4.Text, out maxValue))
                {
                    Process myProcess = new Process();
                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.FileName = "TextFile.exe";
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.StartInfo.Arguments = "-g" + " " + arrsize + " " + minValue + " " + maxValue;
                    myProcess.Start();
                    myProcess.WaitForExit();

                }
                else
                {
                    MessageBox.Show("Не сте попълнили числата");
                }
            }
            else MessageBox.Show("Не сте избрали файл");
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Моля генерирайте файл");
            }
            else {
                 Process myProcess = new Process();
                 myProcess.StartInfo.UseShellExecute = false;
                 myProcess.StartInfo.FileName = "TextFile.exe";
                 myProcess.StartInfo.CreateNoWindow = true;
                 myProcess.StartInfo.Arguments = "-s" + " " + path + " " + dirPath;
                 myProcess.Start();
                myProcess.WaitForExit();

            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Моля генерирайте и сортирайте файла");
            }
            else {
                Process myProcess = new Process();
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.FileName = "TextFile.exe";
                myProcess.StartInfo.CreateNoWindow = false;
                myProcess.StartInfo.Arguments = "-v" + " " + path + " " + dirPath;
                myProcess.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File | *.txt";
            save.Title = "Save a text file";

            if (save.ShowDialog() == DialogResult.OK)
            {
                path = save.FileName;
                dirPath = Path.GetDirectoryName(path);
            }
            using (StreamWriter pathOutput = new StreamWriter("pathOutput.txt"))
            {
                pathOutput.WriteLine(path);
            }
            using (StreamReader pathRead = new StreamReader("pathOutput.txt"))
            {
                FilePath = pathRead.ReadLine();
            }
            using (StreamWriter dirOutput = new StreamWriter("dirOutput.txt"))
            {
                dirOutput.WriteLine(dirPath + "\\");
            }
            textBox1.Text = path;
            save.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists("pathOutput.txt"))
            {
                File.Delete("pathOutput.txt");
            }
            if (File.Exists("dirOutput.txt"))
            {
                File.Delete("dirOutput.txt");
            }
        }
    }
}