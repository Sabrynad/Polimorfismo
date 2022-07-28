using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Src
{
    public class Ave : Animal
    {
        public Ave(string nome, int idade, string cor, string espécie) : base(nome, idade, cor, espécie)
        { 
        }

        public override void Comer()
        {
            Console.WriteLine($" estou comendo hummm");
        }

        public void Voando()
        {
            Console.WriteLine($" estou voando");
        }
    }
}