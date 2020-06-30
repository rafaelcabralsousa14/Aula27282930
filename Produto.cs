using System;
using System.IO;
using System.Collections.Generic;

namespace Aulas27282930
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome  { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/produto.csv";

        
        public Produto(){
            string pasta = PATH.Split('/')[0];
            if(Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }
            // Cria o arquivo, caso ele não exista
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }

        public void Cadastrar(Produto p){
            string[] linha = new string[] {PrepararLinha(p)};
            File.AppendAllLines(PATH, linha);
        }

        public List<Produto> Ler(){
            List<Produto> prod = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);
            foreach (string linha in linhas)
            {
                string[] dado = linha.Split(';'); 
            
                Produto p = new Produto();
                p.Codigo = Int32.Parse(Separar(dado[0]));
                p.Nome = Separar(dado[1]);
                p.Preco = float.Parse(Separar(dado[2]));

                prod.Add(p);
            }

            return prod;           
        }

        public string Separar(string dado){
            return dado.Split('=')[1];
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