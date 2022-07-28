using app.Src;
using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Rogerinho = new Ave("Rogerinho", 3, "Ave", "azul");

            Animal Mario = new Cavalo("Mario", 1, "Cavalo", "preto");

            Mario.Dormir();

            Rogerinho.Dormir();
        }
    }
}
