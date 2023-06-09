using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND2_OOPSPrograms
{
    internal class AlbumTest
    {
        public void albumTest()
        {
            bool debug = false;

            //Create an album with its default constructor
            PhotoAlbum myAlbum1 = new PhotoAlbum();
            Console.WriteLine(myAlbum1.GetNumberOfpages());

            //Create an album with 24 pages
            PhotoAlbum myAlbum2 = new PhotoAlbum(24);
            Console.WriteLine(myAlbum2.GetNumberOfpages());

            //Create an BigPhotoAlbum 
            BigPhotoAlbum myBigPhotoAlbum1 = new BigPhotoAlbum();
            Console.WriteLine(myBigPhotoAlbum1.GetNumberOfpages());

            if (debug)
                Console.ReadLine();
        }
    }
}
