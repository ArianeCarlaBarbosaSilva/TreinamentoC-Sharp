using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsharpOO2;

namespace CsharpOO
{
    class Program
    {
        public static void VerificarVeiculo(Veiculo veiculo)
        {
            Console.WriteLine(veiculo.ToString());
        }

        public static List<T> ImportarVeiculos<T>(string CSVPath)
        where T : Veiculo, new()
        {
            var todasAsLinhas = File.ReadAllLines(CSVPath);
            List<T> veiculos = todasAsLinhas.Skip(1).Select(m => {
                string[] veiculoInf = m.Split(";");
                var car =  new T();
                car.placa = veiculoInf[0];
                car.cor = veiculoInf[1];
                car.marca = veiculoInf[2];
                car.modelo = veiculoInf[3];
                return car;
            }).ToList<T>();
            return veiculos;
        }
        public static void Main(string[] args)
        {
            // Carro car = new Carro("abc-1234");
            // Caminhao caminhao = new Caminhao("cba4321");
            // Moto moto = new Moto("aaa_1111");

            // veiculos.Add(car);
            // veiculos.Add(caminhao);
            // veiculos.Add(moto);
            List<Carro> veiculos = ImportarVeiculos<Carro>("C:/Users/ariane.barbosa/Documents/Programas/Concert/Treinamento C-Sharp/CsharpOO/CSV/veiculos.csv");
            foreach(var veiculo in veiculos)
            {
                VerificarVeiculo(veiculo);
            }
        }
    }
}
