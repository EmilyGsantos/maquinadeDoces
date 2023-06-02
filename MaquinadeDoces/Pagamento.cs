using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MaquinadeDoces
{
    class Pagamento   // Model
    {
        // aqui estao todas as variaveis 
        private int codigo;
        private double valorTotal;
        private short formaPagamento;
        private DateTime dataHora;
        private int codCartao;
        private short bandeiraCartao;
        private double trocoMaquina;
        private double Troco;
        // Criação do construtor (usado para instanciar as variaveis "dar vida as variaveis")

        public Pagamento()

        {
            ModificarCodigo = 0;
            ModificarvalorTotal = 0;
            ModificarFormaDePagamento = 0;
            ModificarDataHora = new DataTime();
            ModificarCodCartao = 0;
            ModificarbandeiraCartao = 0;
            ModificartrocoMaquina = 100;
            Modificartroco = 0;
        } // fim  do construtor

        // Metodo GET  e Set 


        public double Modificartroco()
        {
            get { return.troco; }
            set { this.troco = value};

        }
         
        public int ModificarCodigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }
            


        public int ModificarvalorTotal
        {
            get { return this.valorTotal; }
            set { this.valorTotal = value; }

        } // fim 

        public int ModificarformaDePagamento
        {
            get { return this.formaDePagamento; }
            set { this.formaDePagamento = value; }

        } // fim 

        public string VerificarNotas (double entradaDinheiro, double valorProduto)
        {
            if ( entradaDinheiro >= valorProduto) 
            {
                return "OK";
            }
            else
            {
                return "NO ok";      
            }
        }// fim do verificar Notas 




        // Cada metodo so pode criar uma operação 

        public Boolean ExisteTroco (double entradaDinheiro, double ValorProduto)
        {
            if (entradaDinheiro > valorProduto)
            {
                return true;
            }
                return false;
        }// fim do existe troco 

        public double  ModificarTrocoMaquina
        {
            get { return this.trocoMaquina; }
            set { this.trocoMaquina = value; }


        } // fim do Modificar Set e Get 

        // Metodos do Modelo de Negocio  // string resposta = VerificarNotas (double entradaDinheiro, double valorProduto)

        public double VerificarTroco(double entradaDinheiro, double ValorTotal)
        {

            Boolean respTroco = false;
            respTroco = ExisteTroco(entradaDinheiro, valorProduto);
            if (respTroco == true)
            {
                Modificartroco = entradaDinheiro - valorProduto;
            } // fim 

            else
            {
                ModificarTroco = 0;

            }
        }// fim do verificar troco


    public string MenuForamadePagamento() 
    {
        return "escolha uma das opçoes abaixo: " + "\n1. Dinheiro, \n2. cartao ";
    }// fim do  metodo 




    public void  EfetuarPagamentoDinheiro ( double entradaPagamneto, double valorProduto) 
    {     string resp = "";
          resp = VerificarNotas(entradaPagamento, valorProduto);
        {
                if (resp == "ok")
                {
                   
                    ModificarCodigo++;
                    ModificarValorTotal = valorProduto;
                    ModificarFormaPagamento = 1;
                    ModificarDataHora = DateTime.Now; // pegar a data e hora da transação
                    ModificarTrocoMaquina += valorProduto;
                    VerificarTroco(entradaPagamneto, valorProduto);
                    
                }// fim do if 
                
          
        }// fim do metodo opcao 
       
    }// fim do metodo efetuar 
       

    public void  EfetuarPagamentoCartao(double entradaPagamento, double valorProduto, int codCartao,short Bandeiracartao)

        {
            ModificarCodigo++;
            ModificarValorTotal = valorProduto;
            ModificarFormaPagamento = 2;
            ModificarBnadeiraCartao = bandeiraCartao;
            ModificarCodCartao = codCartao;



        }// fim do EfetuarPagamento Cartao 

    // METODO IMPRIMIR 
    public string Imprimir () // imprimir as notas 
    {
            return "codigo:"              + ModificarCodigo +
                "\nValorTotal:"           + ModificarValorTotal +
                "\n Troco "               +  Modificartroco  +
                "\nForma de Pagamento "   + ModificarFormaDePagamento +
                "\n Data e Hora "         + ModificarDataHora;
             
    }// fim do metodo imprimir 



       

     } // fim da classe
       
} // Fim do Projeto 
