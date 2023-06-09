using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND2_OOPSPrograms
{
    class PhotoAlbum
    {
        private int numberOfpages;

        public void SetNumberOfpages(int numberOfpages)
        {
            this.numberOfpages = numberOfpages;
        }

        public int GetNumberOfpages()
        {
            return numberOfpages;
        }

        public PhotoAlbum()
        {
            numberOfpages = 16;
        }

        public PhotoAlbum(int numberOfpages)
        {
            this.numberOfpages = numberOfpages;
        }
    }
}
