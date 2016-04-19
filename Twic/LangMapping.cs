using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Twic.Lang;

namespace Twic
{
    public enum Language
    {
        /// <summary>
        /// Sets language according to CurrentCultureInfo
        /// </summary>
        Auto, English, Spanish, French
    }

    public static partial class Extensions
    {

        private static readonly List<TwicBase> Languages = new List<TwicBase>
        {
            new English(),
            new Spanish(),
            new French()
        };

        /// <summary>
        /// ToWordsInCulture Extension
        /// </summary>
        /// <param name="number"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        public static string Twic(this int number, Language lang = Language.Auto)
        {
            return lang == Language.Auto
                ? Languages.First(x => x.CultureKey == CultureInfo.CurrentCulture.Parent.EnglishName.ToUpper())
                    .Write(number)
                : Languages.First(x => x.Lang == lang).Write(number);
        }

        /// <summary>
        /// ToWordsInCulture Extension
        /// </summary>
        /// <param name="number"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        public static string Twic(this decimal number, Language lang = Language.Auto)
        {
            number = Math.Round(number, 2);
            var s = new[] { NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator };
            var splited = number.ToString(CultureInfo.InvariantCulture).Split(s, StringSplitOptions.None);
            int nd;
            int.TryParse(splited[0], out nd);
            var cents = "00/100";
            if (splited.Length > 1)
            {
                int d;
                int.TryParse(splited[1], out d);
                cents = d + "/100";
            }

            var words = nd.Twic(lang);

            return words + " " + cents + " ";
        }

        /// <summary>
        /// ToWordsInCulture Extension
        /// </summary>
        /// <param name="number"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        public static string Twic(this double number, Language lang = Language.Auto)
        {
            number = Math.Round(number, 2);
            var s = new[] { NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator };
            var splited = number.ToString(CultureInfo.InvariantCulture).Split(s, StringSplitOptions.None);
            int nd;
            int.TryParse(splited[0], out nd);
            var cents = "00/100";
            if (splited.Length > 1)
            {
                int d;
                int.TryParse(splited[1], out d);
                cents = d + "/100";
            }

            var words = nd.Twic(lang);

            return words + " " + cents + " ";
        }

        /// <summary>
        /// ToWordsInCulture Extension
        /// </summary>
        /// <param name="number"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        public static string Twic(this float number, Language lang = Language.Auto)
        {
            number = (float) Math.Round(number, 2);
            var s = new[] { NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator };
            var splited = number.ToString(CultureInfo.InvariantCulture).Split(s, StringSplitOptions.None);
            int nd;
            int.TryParse(splited[0], out nd);
            var cents = "00/100";
            if (splited.Length > 1)
            {
                int d;
                int.TryParse(splited[1], out d);
                cents = d + "/100";
            }

            var words = nd.Twic(lang);

            return words + " " + cents + " ";
        }
    }
}
