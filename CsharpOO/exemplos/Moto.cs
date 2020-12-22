using System;

namespace CsharpOO2
{
    public class Moto : Veiculo
    {
        public int numeroQuedas{get; set;}

        public Moto() { }
        public Moto(string placa) : base(placa)
        { }

        public override int QuantidadeDePneus(){
            return 2;
        }
    }
}