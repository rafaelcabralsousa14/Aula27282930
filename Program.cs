using System;

namespace Aulas27282930
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Hoverboard", 4000f);
            p1.Cadastrar(p1);

            
        }
    }
}
