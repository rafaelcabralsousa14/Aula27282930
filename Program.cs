using System;
using System.Collections.Generic;

namespace Aulas27282930
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Hoverboard", 4000f);
            p1.Cadastrar(p1);

            List<Produto> lista = p1.Ler();

            foreach (Produto item in lista)
            {
                System.Console.WriteLine($"Nome: {item.Nome} \nPreço: R${item.Preco}");
            }
        }
    }
}
