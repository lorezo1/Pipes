
using System;

namespace CompAndDel{

    public class GuardarFilter:IFilter{

        public IPicture Filter(IPicture image){

            PictureProvider provider = new PictureProvider();

            provider.SavePicture(image, @"cervecita.jpg");

            return image;

        }


    }



}