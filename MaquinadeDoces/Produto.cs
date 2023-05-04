using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MaquinadeDoces
{
    class Produto
    {
        // Definindo Variaveis sempre em letra minuscula
        private int codigo;
        private string nome;
        private string descricao;
        private double preco;
        private int quantidade;
        private DateTime dtValidade;
        private Boolean situacao;

        // Metodo Construtor -> Define situaçao de incio das variaveis 
        public Produto() // construtor sem parametro  (abaixo foi feito o encapsulamento para nao chamar  as variaveis diretamente.)
        {
            ModificarCodigo        = 0;
            ModificarNome          = "";
            ModificarDescricao     = "";
            ModificarPreco         = 0;
            ModificarQuantidade    = 0;
            ModificarDataValidade  = new DateTime(); // 0000/00/00 00:00:00
            ModificarSituacao      = false; // por padrao começa com false 

        }// fim do metodo construtor 

        public Produto(int codigo, string nome, string descricao, double preco, int quantidade, DateTime dtValidade, Boolean situacao)
        {
            ModificarCodigo        = codigo; // this -> usado para fazer referencia a variavel e indentificar quem e parametro. 
            ModificarNome          = nome;
            ModificarDescricao     = descricao;
            ModificarQuantidade    = quantidade;
            ModificarPreco         = preco;
            ModificarDataValidade  = dtValidade;
            ModificarSituacao      = situacao;
        } // fim do metodo construtor com parametros 


        // METODOS GET e SEt -> São metodos de acesso e modificação 
        public int ModificarCodigo
        {
            get{
                return this.codigo; // retorna em tela o codigo 
            } // fim do get 

            set{
                this.codigo = value;
            }// fim do set - modificar o codigo 

        }// fim da modificação 

        public string ModificarNome    // get e set abaixo 
        { 
         get { return this.nome; }
         set { this.nome = value; } 
           }

        public string ModificarDescricao
        {
            get { return this.descricao; }
            set { this.descricao = value;}
        }

        public double ModificarPreco
        {
            get { return(double)this.preco; }
            set { this.preco = value; }

        }

        public int ModificarQuantidade
        {
            get { return this.quantidade; }
            set { this.quantidade = value; }
        }

        public DateTime ModificarDataValidade 
        {
            get { return this.dtValidade; }
            set { this.dtValidade = value; }
           
        }

        public Boolean ModificarSituacao
        {
            get { return this.situacao;}
            set { this.situacao = value;}
        }



        // METODO CADASTRAR PRODUTO//
        public void CadastrarProduto(

            int codigo,
            string nome,
            string descricao,
            double preco,
            int quantidade,
            DateTime dtValidade,
            Boolean situacao

            )
        {
            ModificarCodigo         = codigo;  // = e usado aqui para atribuir 
            ModificarNome           = nome;
            ModificarDescricao      = descricao;
            ModificarPreco          = preco;
            ModificarQuantidade     = quantidade;
            ModificarDataValidade   = dtValidade;
            ModificarSituacao       = situacao;

        } // FIM do metodo cadastrar produto 

        // METODO CONSULTAR produto 

        public string ConsultarProduto(int codigo)
        {
            string msg = ""; // criando variavel local 

            if(ModificarCodigo == codigo)  // comparar usamos 2 ==, (!=  e diferente)
            {
                msg = "\nCodigo: "         + ModificarCodigo       +
                      "\nNome: "           + ModificarNome         +
                      "\nDescricao: "      + ModificarDescricao    +
                      "\nPreco:"           + ModificarPreco        +
                      "\nQuantidade"       + ModificarQuantidade   +
                      "\nDataValidade:"    + ModificarDataValidade +
                      "\nSituacao: "       + ModificarSituacao;
            }

            else
            {
                msg = " O código digitado não existe! ";  
            }

            return msg;
        } // fim do metodo 


        // Metodo de ATUALIZAR 

        public Boolean AtualizarProduto(int codig,int campo,string novoDado) // colocar oq vai ser atualizado, e qual dado ele ira receber 
        {
            Boolean flag = false;
          if (ModificarCodigo == codigo)
            {
                switch(campo) // escolha caso 
                {
                    case 1:
                        ModificarNome = novoDado;
                        flag = true;
                        break; // quebra a operaçao 

                    case 2:
                        ModificarDescricao = novoDado;
                        flag = true;
                        break;

                   case 3:
                        ModificarPreco = Convert.ToDouble(novoDado); // CONVERTE O DADO 
                        flag = true;
                        break;

                   case 4:
                        ModificarQuantidade = Convert.ToInt32(novoDado); 
                        flag = true;
                        break;

                   case 5:
                        ModificarDataValidade = Convert.ToDateTime(novoDado);
                        flag = true;
                        break;

                   case 6:
                        ModificarSituacao = Convert.ToBoolean(novoDado);
                        flag = true;
                        break;

                    default: // 
                        break;

                } // fim do escolha
                return flag;
            } // fim do if 
            return flag;
        }// fim do atualizar produto 
      

        // DESATIVAR PRODUTO //

        public void AlterarSituacao(int codigo)
        {
            if (ModificarCodigo == codigo)
            {
                if(ModificarSituacao == true)
                {
                    ModificarSituacao = false;
                } // fim modificar situacao 
                else
                { 
                    ModificarSituacao = true;

                } //fim modificar situacao 
                flag = true;

            } // fim do modificar codigo 
            return flag;
            
        }// Fim alterarSituacao



        // Solicitar Produtos 
        public Boolean SolicitarProduto(int codigo)
        {
            if (ModificarCodigo == codigo)
            {
                if (ModificarQuantidade <= 3)
                {
                    return true;
                }

            }// fim do if 
           
            return false;

        }// fim  Solicitar Produto
    } // fim da classe 

} // fim do projeto 
