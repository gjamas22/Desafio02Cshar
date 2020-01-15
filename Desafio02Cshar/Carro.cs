using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio02Cshar
{
    class Carro : Veiculo
    {
        public String _marca;
        public int _portas;
        public int _anos;

        public Carro(string modelo, int velocidade, int passageiros, int combustivel ,string marca, int portas, int anos) : base (modelo,velocidade,passageiros,combustivel)
        {
            this._marca = marca;
            this._portas = portas;
            this._anos = anos;
            
        }

        public Carro()
        {
        }

        public String marca { get; set; }
            public int portas { get; set; }
            public int anos { get; set; }

        public void exibirDadosCarro()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("O modelo do seu carro é " + this._modelo);
            Console.WriteLine("Sua velocidade é de " + this._velocidade + " km por hora");
            Console.WriteLine("O carro tem :" + this._passageiros + " passageiros");
            Console.WriteLine("O combustivel é de: " + this._combustivel + " litros");
            Console.WriteLine("A marca do carro é : " + this._marca);
            Console.WriteLine("O carro possue : " + this._portas + " portas");
            Console.WriteLine("O ano do carro é : " + this._anos);
        }
    }

}
