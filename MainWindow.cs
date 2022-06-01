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

namespace CSV_Export_Testdatei
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            string year = DateTime.Now.Year.ToString();
            string month;
            string day;
            string hour;
            string minute;
            string second;


            if (DateTime.Now.Month < 10) month = "0" + DateTime.Now.Month.ToString();
            else month = DateTime.Now.Month.ToString();

            if (DateTime.Now.Day < 10) day = "0" + DateTime.Now.Day.ToString();
            else day = DateTime.Now.Day.ToString();

            if (DateTime.Now.Hour < 10) hour = "0" + DateTime.Now.Hour.ToString();
            else hour = DateTime.Now.Hour.ToString();

            if (DateTime.Now.Minute < 10) minute = "0" + DateTime.Now.Minute.ToString();
            else minute = DateTime.Now.Minute.ToString();

            if (DateTime.Now.Second < 10) second = "0" + DateTime.Now.Second.ToString();
            else second = DateTime.Now.Second.ToString();


            string fileName = txtBoxCommission.Text + "_" + year + "-" + month + "-" + day + "_" + hour + "-" + minute + "-" + second + ".csv";

            textBoxDate.Text = fileName;

            string file = txtBoxPath.Text + @"\" + fileName; 

            

            FileStream fs = new FileStream(file, FileMode.Create);
            fs.Close();


            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.ShowDialog();
            string path = folderBrowserDialog.SelectedPath;

            txtBoxPath.Text = path;
        }

 
    }
}
