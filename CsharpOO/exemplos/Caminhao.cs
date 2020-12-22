using System;

namespace CsharpOO2
{
    public class Caminhao : Veiculo
    {
        public int numeroEixos {get; set;}

        public Caminhao(){ }
        public Caminhao(string placa) : base(placa)
        { }

        public override int QuantidadeDePneus(){
            return numeroEixos*2;
        }
    }

}