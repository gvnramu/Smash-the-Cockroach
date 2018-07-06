using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace game
{
    class BitmapImage
    {
        private Uri uri;
        private string p;

        public BitmapImage(Uri uri)
        {
            // TODO: Complete member initialization
            this.uri = uri;
        }

        public BitmapImage(Uri uri, string p)
        {
            // TODO: Complete member initialization
            this.uri = uri;
            this.p = p;
        }
    }
}
