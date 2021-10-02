using System;

namespace GildedRose
{
    public class Quality
    {
        private int _quality;

        public Quality(int quality)
        {
            _quality = quality;
        }

        public void Quality_Minus()
        {
            if (_quality > 0)
                  _quality -= 1;
        }

        public void Quality_Plus()
        {
            if (_quality < 50)
                _quality += 1;
        }

        public override string ToString()
        {
            return _quality.ToString();
        }

        internal void Zero()
        {
            _quality = 0;
        }
    }
}