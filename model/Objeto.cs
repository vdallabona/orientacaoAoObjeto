namespace Objeto{
    public class Objeto{
        public string? Nome {get; set;}
        public double Altura {get; set;}
        public double Peso {get; set;}
        public string? Cpf {get; set;}
        public int Idade {get; set;}
        
          public void Apresentar(){
            Console.WriteLine($"Oi, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
        public void Andar(){
            Console.WriteLine();
        }
    }

    public class Cachorro{
        public string? Nome {get; set;}
        public string? Dono {get; set;} // o ? permite que o valor seja nulo, evitando o aviso amarelo
        public int idade {get; set;}
        public int QtdBrinquedos {get; set;}
        public bool Dormindo {get; set;}
        public bool Fome {get; set;}

          public void Brincar(){
            if (Dormindo == true){
                Console.WriteLine($" não brincou porque está dormindo.");
            }else{
                Console.WriteLine($" está brincando.");
            }
        }
        public void Dormir(){
            if (Dormindo == true){
                Dormindo = false;
                Console.WriteLine(" acordou.");
            }else{
                Dormindo = true;
                Console.WriteLine(" caiu no sono.");
            }
        }
        public void Comer(){
            if (Fome == true){
                Fome = false;
                Console.WriteLine(" comeu e está satisfeito.");
            }else{
                Console.WriteLine(" não está com fome.");
            }
        }
    }
    
}