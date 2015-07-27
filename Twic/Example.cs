namespace Twic
{
    public class Example
    {
        public Example()
        {
            decimal aNumber = 2137912;

            //next line will detect language according to CultureInfo.CurrentCulture
            var auto = aNumber.Twic();
            
            //force English
            var forceEnglish = aNumber.Twic(Language.English);

            //force spanish
            var forceSpanish = aNumber.Twic(Language.Spanish);

            //If you like this please extend with the languages you know.
        }
    }
}
