using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libface
{
    public class FaceInfo
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Age { get; set; }

        public string Sex { get; set; }

        public string Glasses { get; set; }

        public string SkinColor { get; set; }

        public string Beard { get; set; }

        public string HairSize { get; set; }

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