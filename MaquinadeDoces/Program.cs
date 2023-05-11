using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinadeDoces
{
    internal class Program
    {
        static void Main(string[] args) // responsavel pela entrada e saida de dados

        {
            ControlProduto controlProd = new ControlProduto();
            controlProd.ColetarDados();

            controlProd.Consultar();

            controlProd.Atualizar();



            // leitura da direita para esquerda 

            /*

            // Coletar os Dados 
            Console.WriteLine("Informe um código:");
            int codigo = Convert.ToInt32(Console.ReadLine()); //read line e um metodo que so le texto 

            Console.WriteLine("Informe o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Faça uma breve descricao do produto:");
            string descricao = Console.ReadLine();

            Console.WriteLine("informe o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a quantidade ");
            int quantidade = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("informe a data de validade do produto: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe a situaçao: True - ativo / False - Inativo");
            Boolean situacao = Convert.ToBoolean(Console.ReadLine());

             // Instanciar a classe produto
            Produto prod = new Produto(codigo, nome, descricao,preco, quantidade,data, situacao ); // Estou chamando o Metodo construtor da Maquina de Doces; colocando os nomes das variaveis criadas em cima dentro das ()

            // tudo oq fizer aqui faz é referente ao  prod 
            

            
            

       

           
            */
            


            Console.ReadLine(); // manter a janela aberta o msm q o leia no portugol 
        }// fim do metodo main 
    }// fim da classe 
}// fim do projeto 