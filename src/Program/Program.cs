using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {

        //EJERCICIO 1
        static void Main(string[] args)
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");

            IPipe Nnull = new PipeNull();

            IFilter filter = new FilterNegative();

            IPipe serial = new PipeSerial(filter, Nnull);

            IFilter grey = new FilterGreyscale();

            IPipe sserial = new PipeSerial(grey,serial);

            IPicture imagen = sserial.Send(picture); 

            provider.SavePicture(imagen, @"beer2.jpg");


            //EJERCICIO 2

            PictureProvider pprovider = new PictureProvider();
            IPicture pictures = pprovider.GetPicture(@"beer.jpg");

            IPipe Nnulll = new PipeNull();

            IFilter guardar = new GuardarFilter();

            IPipe serial2 = new PipeSerial (guardar, Nnulll);

            IFilter filterr = new FilterNegative();

            IPipe seriall = new PipeSerial(filterr, serial2);

            IFilter greyy = new FilterGreyscale();

            IPipe sseriall = new PipeSerial(greyy,seriall);

            IPicture imagenn = sseriall.Send(pictures); 

          
          //EJERCICIO 3

            PictureProvider provide = new PictureProvider();
            IPicture picturess = provide.GetPicture(@"beer.jpg");

            IPipe nulo = new PipeNull();

            IFilter publicar = new PublicarFilter();

            IPipe serial3 = new PipeSerial (publicar, nulo);

            IFilter filtro = new FilterNegative();

            IPipe serial4 = new PipeSerial(filtro, serial3);

            IFilter gris = new FilterGreyscale();

            IPipe seriaal = new PipeSerial(gris,serial4);

            IPicture foto = sseriall.Send(picturess); 


        ///EJERCICIO 4

            PictureProvider providee = new PictureProvider();
            IPicture pictures1 = providee.GetPicture(@"beer.jpg");

            IPipe nul1 = new PipeNull();

            IFilter negative = new FilterNegative();

            IPipe serial0 = new PipeSerial(negative, nul1);

            IFilter tweeter = new PublicarFilter();

            IPipe serial5 = new PipeSerial(tweeter, nul1);

            CondicionalFilter condicion = new CondicionalFilter();

            IPipe fork = new PipeCondicional(condicion, serial5, serial0);

            IFilter scale = new FilterGreyscale();

            IPipe serial6 = new PipeSerial(scale, fork);

            IPicture fotito = serial6.Send(pictures1);


        }
    }
}
