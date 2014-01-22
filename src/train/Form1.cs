using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace train
{
    public partial class Form1 : Form
    {
        private FaceRecognizer faceRecognizer = new FaceRecognizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadTestImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            faceRecognizer.CurrentImage = new Image<Bgr, byte>(dlg.FileName);
            faceRecognizer.recognizeFaces();
            this.imgTest.Image = faceRecognizer.CurrentImage;
        }

        private void btnLoadTrainImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            faceRecognizer.CurrentImage = new Image<Bgr, byte>(dlg.FileName);
            this.imgTrain.Image = faceRecognizer.CurrentImage;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
        }

        private void btnDetectFaces_Click(object sender, EventArgs e)
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