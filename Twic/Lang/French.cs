using System;

namespace Twic.Lang
{
    public class French : TwicBase
    {
        public override Language Lang
        {
            get { return Language.French; }
        }

        public override string CultureKey
        {
            get { return "FRENCH"; }
        }

        public override string Write(int number)
        {
            if (number == 0)
                return "zéro";

            if (number < 0)
                return "moins " + Write(Math.Abs(number));

            var words = "";

            if ((number / 1000000) > 0)
            {
                var millones = number / 1000000;
                words += Write(millones) + (millones == 1 ? " million " : " millons ");
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                var milliers = number / 1000;
                words += ((milliers == 1) ? "" : Write(milliers)) + " mille ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                var centaines = number / 100;
                words += centaines == 1 ? "cent " : Write(centaines) + "-cents ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number < 30)
                    words += Extensions.UnitesMap[number];
                else
                {
                    words += Extensions.DizainesMap[number / 10];
                    var remaining = number % 10;
                    if (remaining > 0)
                    {
                        if (remaining == 1)
                            words += "-et-" + Extensions.UnitesMap[remaining];
                        else
                            words += "-" + Extensions.UnitesMap[remaining];
                    }
                }
            }

            return words;
        }
    }
}
