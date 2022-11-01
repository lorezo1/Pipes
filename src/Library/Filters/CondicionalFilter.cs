using System; 
using CognitiveCoreUCU;

namespace CompAndDel{

    public class CondicionalFilter:IFilter{


        bool TieneCara;


        public IPicture Filter(IPicture image){

            PictureProvider provider = new PictureProvider();
            provider.SavePicture(image, @"condicional.jpg");
           
            CognitiveFace cog = new CognitiveFace();
            cog.Recognize(@"condicional.jpg");

            if (cog.FaceFound){

                TieneCara = true;

            }
                
                else {
                    TieneCara = false;
                }

            return image;
        }

        public bool ConCara(){

            return TieneCara;
        }

    }

}
