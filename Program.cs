using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Personagem vegeta = new Personagem();
            vegeta.nome = "Vegeta";
            vegeta.armadura = "Sayajin";
            vegeta.idade = 18;
            float potencia;
            float forca;
            

            Console.WriteLine("O nome do personagem é {0,1}",vegeta.nome);
            Console.WriteLine();
            Console.WriteLine(vegeta.defender());
            Console.WriteLine();
            Console.WriteLine("Não é possivel!");  
            Console.WriteLine();
            Console.WriteLine("O seu poder é mais de OITO MIL ultrapassando "+vegeta.Atacar(forca = 38.5f, potencia = 312f ));
            // Console.WriteLine(vegeta.Atacar(forca, potencia));
        }
    }
}
