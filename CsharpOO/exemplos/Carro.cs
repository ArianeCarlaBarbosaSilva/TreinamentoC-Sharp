using System;

namespace CsharpOO2
{
    public class Carro : Veiculo
    {
        public int numeroLugares {get; set;}

        public Carro(){ }
        public Carro(string placa) : base(placa)
        { }

        public override int QuantidadeDePneus(){
            return 4;
        }
    }
}