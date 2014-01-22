using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace train
{
    public class FaceRecognizer
    {
        #region public propeties

        /// <summary>
        /// currentImage
        /// </summary>
        public Image<Bgr, Byte> CurrentImage { get; set; }

        #endregion public propeties

        #region private members

        /// <summary>
        /// numTrainImages
        /// </summary>
        private int numTrainImages = 0;

        /// <summary>
        /// face haarcascade
        /// </summary>
        private HaarCascade face = new HaarCascade("haarcascade_frontalface_default.xml");

        /// <summary>
        /// font used for drawing names
        /// </summary>
        private MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);

        /// <summary>
        /// trained images
        /// </summary>
        private List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();

        /// <summary>
        /// trainingNames
        /// </summary>
        private List<String> trainingNames = new List<String>();

        #endregion private members

        #region constructor

        /// <summary>
        ///  constructor
        /// </summary>
        public FaceRecognizer()
        {
            this.loadImageDatabase();
        }

        #endregion constructor

        #region loadImageDatabase

        /// <summary>
        /// loadImageDatabase
        /// </summary>
        private void loadImageDatabase()
        {
            // create regex
            Regex regex = new Regex(@"(\w+) \(\d+\).jpg");

            // iterate files in folder
            foreach (string filename in Directory.EnumerateFiles("faces", "*.jpg"))
            {
                // parse label
                Match match = regex.Match(filename);

                // read person name
                string personName = match.Groups[1].Value;

                // add image to list
                trainingImages.Add(new Image<Gray, byte>(filename));
                trainingNames.Add(personName);

                // increment number of train images
                numTrainImages++;
            }
        }

        #endregion loadImageDatabase

        #region recognizeFaces

        public void recognizeFaces()
        {
            //Face Detector
            MCvAvgComp[][] facesDetected = CurrentImage.DetectHaarCascade(face, 1.2, 10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                Image<Gray, Byte> result = CurrentImage.Copy(f.rect)
                    .Convert<Gray, byte>()
                    .Resize(92, 112, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //draw the face detected in the 0th (gray) channel with blue color
                CurrentImage.Draw(f.rect, new Bgr(Color.Red), 2);

                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(numTrainImages, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       trainingNames.ToArray(),
                       3000,
                       ref termCrit);

                    String name = recognizer.Recognize(result);

                    //Draw the label for each face detected and recognized
                    CurrentImage.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
                }
            }
        }

        #endregion recognizeFaces
    }
}