using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;

namespace FaceRecognition
{
    public partial class Form1 : Form
    {
        private HaarCascade face;
        private Image image;

        public Form1()
        {
            InitializeComponent();

            //face = new HaarCascade("haarcascade_frontalface_default.xml");
        }

        private void btnLoadTestImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            picTrainImage.Image = Image.FromFile(dlg.FileName);
        }

        private void btnLoadTrainImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.changeTrainImage(dlg.FileName);
        }

        private void changeTrainImage(string path)
        {
            this.image = Image.FromFile(path);
            picTrainImage.Image = Image.FromFile(path);
        }

        private void changeTestImage(string path)
        {
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}