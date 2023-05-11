using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MaquinadeDoces
{
    class ControlProduto
    {
        Produto prod;
        private int opcao;

        // METODO CONSTRUTOR 
        public ControlProduto()
        {
            prod = new Produto();
            ModificarOpcao = -1;
        }// fim do construtor 


        // METODO GET e SET 
        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }// fim do metodo GET e SET 

        public void Menu()
        {
            
            Console.WriteLine("\n \n \n Escolha uma das opçoes abaixo: \n " +
                "0. SAIR \n " +
                "1. Cadastrar Produto \n "    +
                "2. Atualizar Produto \n "    + 
                "3.   Consultar Produto \n "  +
                "4. Qunatidade \n "           +
                "5. data de validade \n "     +
                "6. Situação \n "             );
                
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());

        }// fim do menu 

        // Realizar a Operaçao 
        public void Operacao()
             {
            do {
                Menu(); // Mostrando o menu na tela
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("obrigado!");
                        Console.Clear(); //  Limpar a tela 
                        break;

                    case 1:
                        ColetarDados();
                        Console.Clear(); //  Limpar a tela 
                        break;

                    case 2:
                        Consultar();
                        Console.Clear(); //  Limpar a tela 
                        break;

                    case 3:
                        Atualizar();
                        Console.Clear(); //  Limpar a tela 
                        break;

                    case 4:
                        AlterarSituacao();
                        Console.Clear(); //  Limpar a tela 
                        break;
                    default:
                        Console.WriteLine("Opção escolhida NAO e valida!");
                        break;
                }// fim do switch 
            } while (ModificarOpcao != 0);  



        }// Fim do metodo operacao 


        // Criar metodo de solicitação de Dados 
        public void ColetarDados()
        {
            // Todos aqui  estao Armazenados em variaveis temporarias para que depois podemos utilizar as operaçoes do crud 
            Console.WriteLine("informe o codigo:");
            int codigo = Convert.ToInt32(Console.ReadLine());

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

            // Cadastrar Produto 

            prod.CadastrarProduto(codigo, nome, descricao, preco, quantidade, data, situacao);
            Console.WriteLine("Dados Registardos!");
        }// fim do coletar dados 

        // CONSULTAR 
        public void Consultar()
        {

            // CONSULTAR Produto 
            Console.WriteLine("\n \n \n informe o codigo do produto que deseja consultar: "); // (/nome) usado para pular linhas 
            int codigo = Convert.ToInt32(Console.ReadLine());

            // Resultado da consulta na tela 
            Console.WriteLine("Os dados do produto escolhidos são: \n \n \n " + prod.ConsultarProduto(codigo));

        }// FIM  do metodo Consultar  


        // ATUALIZAR
        public void Atualizar ()
        {
            Console.WriteLine(" \n \n Informe o codigo do produto que deseja atualizar :");
            int codigo = Convert.ToInt32(Console.Read());

            short campo = 0;
            do
            { // faça 
                Console.WriteLine("Informe o campo que deseja atualizar de acordo com a regra abaixo: \n " +
                    "1.Nome \n " +
                    "2.Descricao \n  " +
                    "3.Preco \n " +
                    "4. Data de validade \n " +
                    "5. Situaçao \n" +
                    "6. Quantidade ");

                campo = Convert.ToInt16(Console.ReadLine());
                // avisar o usuario 
                if ((campo < 1) && (campo > 6))
                {
                    Console.WriteLine("Erro, escolha um codigo entre 1 e 6 :");
                }
            } while ((campo < 1) && (campo > 6));// ate 


            Console.WriteLine("Informe o dado para a atualização :");
            string novoDado = Console.ReadLine(); // string esta guardando 
            // Chamando o metodo de atualizaçao 
            prod.AtualizarProduto(codigo, campo, novoDado);
        }// Fim do metodo atualizar 

        public void AlterarSituacao()
        {
            Console.WriteLine("Informe o codigo de produto que deseja alterar o status: ");
            int codigo = Convert.ToInt32(Console.Read());

            // CHAMAR METODO alterar Produto
            prod.AlterarSituacao (codigo);
            Console.WriteLine("Alterado!");
        }// fim do alterar situaçao 


         // Forma de Pagamento 

       




    }// fim da classe 
}// fim do projeto 
