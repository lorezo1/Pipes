using System; 
using CognitiveCoreUCU;

namespace CompAndDel{

    public class PipeCondicional : IPipe{
        public IPicture Send(IPicture picture){
  
            filtro.Filter (picture);
            bool ConCara = filtro.ConCara ();
        
          
           if (ConCara){return this.Pipe1.Send(picture);}
           else {return this.Pipe2.Send(picture);}


        }
        protected CondicionalFilter filtro;
        protected IPipe Pipe1;
        protected IPipe Pipe2;
        
    public PipeCondicional(CondicionalFilter filtro, IPipe Pipe1, IPipe Pipe2)
        {
            this.Pipe1 = Pipe1;
            this.Pipe2 = Pipe2;
            this.filtro = filtro;
        }
        
    }


}