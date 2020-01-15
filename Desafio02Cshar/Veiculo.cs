using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio02Cshar
{
    class Veiculo
    {
            public String _modelo;
            public int _velocidade;
            public int _passageiros;
            public int _combustivel;
            
            
            public String Modelo { get; set; }
            public String Velocidade { get; set; }
            public int Passageiros { get; set; }
            public int Combustivel { get; set; }

        public Veiculo(string modelo, int velocidade, int passageiros, int combustivel)
        {
            this._modelo = modelo;
            this._velocidade = velocidade;
            this._passageiros = passageiros;
            this._combustivel = combustivel;
            
        }

        public Veiculo()
            {
            }

            public void exibirDadosVeiculo()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Seu veiculo é uma :" + this._modelo);
            Console.WriteLine("Sua velocidade é de : " + this._velocidade + " km  por hora");
            Console.WriteLine("Possue " + this._passageiros + " passageiro");
            Console.WriteLine("Seu tanque está com: " + this._combustivel + "litros");
        }
        }
    }




