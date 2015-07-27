using System;

namespace Twic.Lang
{
    public class Spanish : TwicBase
    {
        public override Language Lang
        {
            get { return Language.Spanish; }
        }

        public override string CultureKey
        {
            get { return "SPANISH"; }
        }

        public override string Write(int number)
        {
            if (number == 0)
                return "cero";

            if (number < 0)
                return "menos " + Write(Math.Abs(number));

            var words = "";

            if ((number / 1000000) > 0)
            {
                var millones = number / 1000000;
                words += Write(millones) + (millones == 1 ? " million " : " millones ");
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                var miles = number / 1000;
                words += (miles > 1 ? UnWritter(miles) : "") + " mil ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                var cientos = number / 100;
                words += Extensions.CientosMap[cientos];
                number %= 100;
                if (cientos == 1 && number > 0) words += "to";
                words += " ";
            }

            if (number > 0)
            {
                if (number < 30)
                    words += Extensions.UnidadesMap[number];
                else
                {
                    words += Extensions.DecenasMap[number / 10];
                    var remaining = number % 10;
                    if ((number % 10) > 0)
                        words += " y " + Extensions.UnidadesMap[remaining];
                }
            }

            return words;
        }

        public string UnWritter(int number)
        {
            var words = "";

            if ((number / 100) > 0)
            {
                var cientos = number / 100;
                words += Extensions.CientosMap[cientos];
                number %= 100;
                if (cientos == 1 && number > 0) words += "to";
                words += " ";
            }

            if (number > 0)
            {
                if (number < 30)
                    words += Extensions.UnidadesMap[number];
                else
                {
                    words += Extensions.DecenasMap[number / 10];
                    var remaining = number % 10;
                    if ((number % 10) > 0)
                        words += " y " + (remaining == 1 ? "un" : Extensions.UnidadesMap[remaining]);
                }
            }

            return words;
        }
    }
}
