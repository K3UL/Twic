namespace Twic
{
    public class Example
    {
        public decimal Number { get; set; }

        public string English { get; set; }
        public string Spanish { get; set; }
        public string French { get; set; }
        public Example(decimal num)
        {
            Number = 2137912;

            //next line will detect language according to CultureInfo.CurrentCulture
            var auto = Number.Twic();
            
            //force English
            English = Number.Twic(Language.English);

            //force spanish
            Spanish = Number.Twic(Language.Spanish);

            //If you like this please extend with the languages you know.
            French = Number.Twic(Language.French);            
        }
    }
}
