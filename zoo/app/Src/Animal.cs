using System;
using System.Text;


namespace app.Src
{
    public class Animal
    {

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Cor { get; set; }

        public string Espécie { get; set; }

        public Animal(string nome, int idade, string cor, string espécie)
        {
            Nome = nome;
            Idade = idade;
            Cor = cor;
            Espécie = espécie;
        }

        public virtual void Dormir()
        {
            Console.WriteLine($"{Nome} está dormindo");
        }
        public virtual void Comer()
        {
            Console.WriteLine($"{Nome} está comendo");
        }

    }

}