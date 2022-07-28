using System;
using System.Text;

namespace app.Src
{

    public class Cavalo:Animal
    {
       

        public override void Dormir() 
        {
           Console.WriteLine($" estou dormindo zZzZzZ"); 
        }

        public override void Comer()
        {
            Console.WriteLine($" estou comendo hummm");
        }

        public void Cavalgar()
        {
             Console.WriteLine($" estou cavalgando");

        }

        public Cavalo(string nome, int idade, string cor, string espécie) : base(nome, idade, cor, espécie)
        {
        }
    }
}