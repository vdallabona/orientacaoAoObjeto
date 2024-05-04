namespace Objeto{
    public class Pastor : Cachorro{
        public int ovelhasGuiadas {get; set;}
        
        public void GuiarOvelhas(){
            ovelhasGuiadas++;
            Console.WriteLine($" guiou {ovelhasGuiadas} ovelhas.");
        }
    }
    public class Policial : Cachorro{
        public int bandidosPresos {get; set;}

        public void PrenderBandido(){
            bandidosPresos++;
            Console.WriteLine($" prendeu {bandidosPresos} bandidos.");
        }
    }
}