using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio02Cshar
{
    class Avião : Veiculo
    {
        public String _tipo;
        public String _uso;

        public Avião(string modelo, int velocidade, int passageiros, int combustivel,string tipo, string uso) :base (modelo,velocidade,passageiros,combustivel)
        {
            this._tipo = tipo;
            this._uso = uso;
         
        }

        public Avião()
        {
        }

        public String tipo { get; set; }
        public String uso { get; set; }

        public void exibirDadosAvião()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("O modelo do avião é " + this._modelo);
            Console.WriteLine("A velocidade do avião é " + this._velocidade + " km por hora");
            Console.WriteLine("O avião possue " + this._passageiros + " passageiros");
            Console.WriteLine("O avião possue " + this._combustivel + " litros de gasolina");
            Console.WriteLine("O tipo do avião é " + this._tipo);
            Console.WriteLine("O uso do avião é para " + this._uso);
        }
    }
}
