using System;

namespace VeiculosAPI.Entities
{
    public class Moto : Veiculo
    {
        public int numeroQuedas{get; set;}
        public int capotesDoGustavao {get; set;}

        public Moto() { }
        public Moto(string placa) : base(placa)
        { }

        public override int QuantidadeDePneus(){
            return 2;
        }
    }
}