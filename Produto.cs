using System.IO;

namespace Aulas27282930
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome  { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/produto.csv";

        
        public Produto(){
            // Cria o arquivo, caso ele não exista
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }

        public void Cadastrar(Produto p){
            string[] linha = new string[] {PrepararLinha(p)};
            File.AppendAllLines(PATH, linha);
        }

        private string PrepararLinha(Produto p){
            return $"código={p.Codigo};nome={p.Nome};preço={p.Preco}";
        }

        public Produto(int _codigo, string _nome, float _preco){
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }

        


    }
}