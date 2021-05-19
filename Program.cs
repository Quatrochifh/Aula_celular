using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {

            celular cel = new celular();
            
            cel.celularzinho = "xiaomi";
            cel.modelo = "MIA3";
            cel.cor = "vermelha";
            cel.tamanho = "6.01 polegadas";
            cel.ligado = false;
            
            Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine(@" 
            =========================================
            |                                       |
            |          o que deseja fazer?          |
            |                                       |
            |   1- abrir configurações do celular   |
            |                                       |
            |   2- Enviar mensagens                 |
            |                                       |
            |   3- Fazer ligação                    |
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            ====================0===================");



            int CelP1 = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("o celular esta desligado, deseja ligar? (s) para Sim (n) para Não");
            string lig = Console.ReadLine() .ToLower();
           
            if (lig == "s")
            {
                cel.Ligar();
            }
            while (cel.ligado == true)
            
            
           
                    
        if (CelP1 == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($@"
                

            =========================================
            |                                       |
            |     essas são as configurações        |
            |         do seu dispositivo            |
            |                                       |
            |           {cel.celularzinho}          |
            |           {cel.modelo}                |
            |           {cel.cor}                   |
            |           {cel.tamanho}               |
            |                                       |              
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            ====================0===================" );
             
                
            }
            else if ( CelP1 == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
               Console.WriteLine($@" 
        
            =========================================
            |                                       |
            | Para quem você deseja                 |
            |                 enviar mensagem?      |
            |          (digite o nome do contato)   |
            |                                       |
            |         1 - Ana                       |
            |         2- Catharina                  |
            |         3- Odirlei                    |
            |         4- Thiago                     |
            |                                       |
            |                                       |
            |                                       |              
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            ====================0===================");
             string contatos = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($@" 
        
            =========================================
            |                                       |
            |     O que você deseja digitar para    |
            |     {contatos}:                       |
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            |                                       |              
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            ====================0===================");
            string mensagem = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine($@" 
        
            =========================================
            |                                       |
            |                                       |
            |          PARA: {contatos}             |
            |                                       |
            |                                       |
            |                                       |
            |   A mensagem é                        |
            |   {mensagem}                          |
            |                                       |
            |       {cel.EnviarMensagem()}          |              
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            ====================0===================");

            }
             else if ( CelP1 == 3)
            {
               Console.ForegroundColor = ConsoleColor.DarkYellow;
               Console.WriteLine($@" 
        
           =========================================
            |                                       |
            | Para quem você deseja                 |
            |                 fazer a ligação?      |
            |          (digite o nome do contato)   |
            |                                       |
            |         1 - Ana                       |
            |         2- Catharina                  |
            |         3- Odirlei                    |
            |         4- Thiago                     |
            |                                       |
            |                                       |
            |                                       |              
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            ====================0===================");
             string ligação = Console.ReadLine();

            Console.WriteLine($@" 
        
            =========================================
            |                                       |
            |                                       |
            |  Realizando chamada com {ligação}     |
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            |       {cel.FazerLigacao()}            |              
            |                                       |
            |                                       |
            |                                       |
            |                                       |
            ====================0===================");

            }
            
        }
    }
}
