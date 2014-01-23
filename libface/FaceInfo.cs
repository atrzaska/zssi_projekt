using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libface
{
    public class FaceInfo
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Age
        /// </summary>
        public string Age { get; set; }

        /// <summary>
        /// Sex
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// Glasses
        /// </summary>
        public string Glasses { get; set; }

        /// <summary>
        /// SkinColor
        /// </summary>
        public string SkinColor { get; set; }

        /// <summary>
        /// Beard
        /// </summary>
        public string Beard { get; set; }

        /// <summary>
        /// HairSize
        /// </summary>
        public string HairSize { get; set; }

        /// <summary>
        /// FaceInfo
        /// </summary>
        public FaceInfo()
        {
        }

        /// <summary>
        /// FaceInfo
        /// </summary>
        public FaceInfo(string name)
        {
            this.Id = name;
        }

        /// <summary>
        /// ToString
        /// </summary>
        public override string ToString()
        {
            return "Imię: " + FirstName + "\r\n" +
                "Nazwisko: " + LastName + "\r\n" +
                "Wiek: " + Age + "\r\n" +
                "Płeć: " + Sex + "\r\n" +
                "Okulary: " + Glasses + "\r\n" +
                "Kolor skóry: " + SkinColor + "\r\n" +
                "Broda: " + Beard + "\r\n" +
                "Dł. włosów: " + HairSize;
        }
    }
}