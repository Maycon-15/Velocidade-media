using System;

namespace Velocidade_media
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Double Velocidade, Tempo, Distancia;

            Console.WriteLine("Vamos calculara velocidade media, digite abaixo a distância, em metros (m), que o carro terá de percorrer para chegar ao posto de gasolina");
            Distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite o tempo, em segundos (s), que o carro demorou para chegar ao posto de gasolina:");
            Tempo = Convert.ToDouble(Console.ReadLine());

            Velocidade = Distancia / Tempo;

            Console.WriteLine($"A velocidade média do carro é de: {Velocidade}");
        }
    }
}
