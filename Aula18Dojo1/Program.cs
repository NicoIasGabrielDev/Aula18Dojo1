using System;

namespace Aula18Dojo1
{
    // 
    //
    //Pq está dando erro aqui?
    //
    class Program
    {
        static void Main(string[] args)
        {

            Jogador neymar = new Jogador();
            neymar.Nome = "Neymar Jr.";
            neymar.Posicao = "Atacante";
            neymar.Nascimento = DateTime.Parse("05/02/1992");            
            //ação de mostrar o dados e calcular idade
            neymar.MostrarDados();
            Console.WriteLine( neymar.CalcularIdade() );
            Console.WriteLine( neymar.CalcularAposentadoria() );

        }
    }
}