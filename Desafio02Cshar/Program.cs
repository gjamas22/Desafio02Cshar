using System;

namespace Desafio02Cshar
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Jeep Renegate", 50, 4, 40, "Jeep", 4, 2009);
            c1.exibirDadosCarro();

			Avião c2 = new Avião("Boing 707", 890, 100, 1000, "para turismo", "comercial");
            c2.exibirDadosAvião();

			Veiculo c3 = new Veiculo("Moto", 50, 1, 100);
            c3.exibirDadosVeiculo();
		}
    }
}
