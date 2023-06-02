using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinadeDoces
{
    class ControlPagamento
    {
        Pagamento pgto;
        private short opcao;
        public ControlPagamento()
        {
            pgto = new Pagamento();  // criando uma conexão 


        }// fim do construtor 

        // GET e Set 
        public short ModificarOpcao
        {
            get { return opcao; }

            set { opcao = value; }

        } // fim do get e set 
         public void EscolherFormaDePagamento()
            
         { 
            Console.WriteLine (pgto.MenuFormaDePagamento()); // mostrando o menu na tela 
            ModificarOpcao = Convert.ToInt16 ((Console.ReadLine())); // coletando a resposta 
        }// fim do registrar pagamento 

        public void Operacao()
        {
            EscolherFormaDePagamento();
            

            switch (ModificarOpcao)
            {
                case 1:
                    Console.WriteLine("Pagamneto com Dinheiro:\n\n");
                    Console.WriteLine("Valor inserido na Maquina: ");
                   double valorInserido = Convert.ToDouble(Console.ReadLine()); // Tudo oq o usuario escrever na tela e lido como texto! entao aqui convertemos sua resposta para uma varivael do tipo double.
                    // double valor inserido: é uma variavel do tipo double
                    Console.WriteLine("\n\n valor do produto: ");
                    double valorProduto = Convert .ToDouble(Console.ReadLine());

                    // Utilizar o metodo pagamento DINHEIRO 
                    pgto.EfetuarPagamentoDinheiro(valorProduto, valorInserido);
                    Console.WriteLine(pgto.Imprimir());
                    break;

                case 2:
                    Console.WriteLine("Pagamneto com Cartão:\n\n");
                    Console.WriteLine("\n\n valor do produto: ");
                    valorProduto = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n\n Codigo do cartao");
                    int codCartao = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n Bandeira Cartao: \n1. Visa  \n 2. Matercard  \n 3. Elo ");
                    short bandeiraCartao = Convert.ToInt16(Console.ReadLine());

                    pgto.EfetuarPagamentoCartao(valorProduto, codCartao)

                    break;

            }// fim do switch 

        }// fim da operaçao 
    }// fim da classe 
} // fim do metodo 
