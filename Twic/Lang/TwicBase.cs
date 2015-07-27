using System;

namespace Twic.Lang
{
    public class TwicBase
    {
        public virtual Language Lang
        {
            get { throw new NotImplementedException(); }
        }

        public virtual string CultureKey
        {
            get { throw new NotImplementedException(); }
        }

        public virtual string Write(int integers)
        {
            return "Not Suported Language";
        }
    }
}
