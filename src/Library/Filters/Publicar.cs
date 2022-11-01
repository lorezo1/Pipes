using System; 
using TwitterUCU;

namespace CompAndDel{

    public class PublicarFilter: IFilter{

        public IPicture Filter(IPicture image){

            PictureProvider provider = new PictureProvider();
            provider.SavePicture(image, @"birra.jpg");

            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("esta lindo para una", @"birra.jpg"));

            return image;

        }

        

    }



}