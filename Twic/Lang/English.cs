using System;

namespace Twic.Lang
{
    public class English : TwicBase
    {
        public override Language Lang
        {
            get { return Language.English;}
        }

        public override string CultureKey
        {
            get { return "ENGLISH"; }
        }

        public override string Write(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + Write(Math.Abs(number));

            var words = "";

            if ((number / 1000000) > 0)
            {
                words += Write(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += Write(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += Write(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                if (number < 20)
                    words += Extensions.UnitsMap[number];
                else
                {
                    words += Extensions.TensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + Extensions.UnitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
