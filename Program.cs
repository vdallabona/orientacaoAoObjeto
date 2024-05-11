namespace Objeto{
    public class Program{
        static void Main(){

            int op = 0;
            string? aMimir = "não informado"; //interrogação para dizer que pode ser nulo
            string? aComer = "não informado";

            Console.WriteLine("Quantos cachorros quer registrar?");
            int NumCachorros = Convert.ToInt32(Console.ReadLine());

            Cachorro[] cachorros = new Cachorro[NumCachorros]; //campo vazio que aceita um cachorro instanciado
            Pastor[] pastor = new Pastor[NumCachorros];
            Policial[] policial = new Policial[NumCachorros];
            for (int i = 0; i < NumCachorros; i++){

                cachorros[i] = new Cachorro(); //cria uma instância de cachorro em um dos espaços do array
                pastor[i] = new Pastor();
                policial[i] = new Policial();

                Console.WriteLine("Qual o nome do cachorro? ");
                cachorros[i].Nome = Console.ReadLine() ?? "";

                Console.WriteLine("E o nome do dono? ");
                cachorros[i].Dono = Console.ReadLine() ?? "";

                Console.WriteLine("Quantos anos seu cão tem? ");
                cachorros[i].idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Quantos brinquedos ele tem? ");
                cachorros[i].QtdBrinquedos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual o trabalho do seu cão? [1] Pastor [2] Policial ");
                cachorros[i].Trabalho = Convert.ToInt32(Console.ReadLine());
                if(cachorros[i].Trabalho == 1){
                    Console.WriteLine("Quantas ovelhas seu pastor guiou?");
                    pastor[i].ovelhasGuiadas =  Convert.ToInt32(Console.ReadLine());
                }else if(cachorros[i].Trabalho == 2){
                    Console.WriteLine("Quantos bandidos seu policial prendeu?");
                    policial[i].bandidosPresos =  Convert.ToInt32(Console.ReadLine());
                }else{
                    Console.WriteLine("Cão desempregado");
                }
                aMimir = "não informado";
                do{
                    if(aMimir != "não informado"){
                        Console.WriteLine("ERRO 325 - Só aceitamos true ou false");
                    }
                    Console.WriteLine("Ele está dormindo no momento? Digite true ou false");
                    aMimir = Console.ReadLine();
                }while(aMimir != "true" && aMimir != "false");
                    cachorros[i].Dormindo = Convert.ToBoolean(aMimir);
                do{
                    if(aComer != "não informado"){
                        Console.WriteLine("ERRO - Só aceitamos true ou false");
                    }
                    Console.WriteLine("Ele está com fome no momento? Digite true ou false");
                    aComer = Console.ReadLine();
                }while(aComer != "true" && aComer != "false");
                    cachorros[i].Fome = Convert.ToBoolean(aComer);
            }

            for (int i = 0; i < NumCachorros; i++){
                Console.Write($"O {i+1}° cachorro é chamado {cachorros[i].Nome}, pertene ao {cachorros[i].Dono}, tem {cachorros[i].idade} anos e {cachorros[i].QtdBrinquedos} brinquedos.");
                if(cachorros[i].Dormindo == true){
                    Console.WriteLine("No momento estou dormindo.");
                }else{
                    Console.WriteLine("No momento estou acordado.");
                }
            }

            do{
                Console.WriteLine("O que quer fazer com os cães?");
                Console.WriteLine("[1] Brincar");
                Console.WriteLine("[2] Botar para dormir/acordar");
                Console.WriteLine("[3] Dar de comer");
                Console.WriteLine("[4] Atividade de trabalho");
                Console.WriteLine("[5] Sair");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op){
                    case 1:{
                        for (int i = 0; i < NumCachorros; i++){
                            Console.Write(cachorros[i].Nome);
                            cachorros[i].Brincar();
                    }
                        break;
                    }
                    case 2:{
                        for (int i = 0; i < NumCachorros; i++){
                            Console.Write(cachorros[i].Nome);
                            cachorros[i].Dormir();
                    }
                        break;
                    }

                    case 3:{
                        for (int i = 0; i < NumCachorros; i++){
                            Console.Write(cachorros[i].Nome);
                            cachorros[i].Comer();
                    }
                        break;
                    }
                    case 4:{
                        for (int i = 0; i < NumCachorros; i++){
                            if(cachorros[i].Trabalho == 1){
                                Console.Write(cachorros[i].Nome);
                                pastor[i].GuiarOvelhas();
                            }else if(cachorros[i].Trabalho == 2){
                                Console.Write(cachorros[i].Nome);
                                policial[i].PrenderBandido();
                            }else{
                                Console.WriteLine("Seu cão é desempregado");
                            }
                        }
                        break;
                    }
                }
            }while(op != 5);
        }
    }
}