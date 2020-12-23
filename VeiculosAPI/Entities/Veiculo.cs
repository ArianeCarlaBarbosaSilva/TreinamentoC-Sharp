using System;
using System.ComponentModel.DataAnnotations;

namespace VeiculosAPI.Entities
{
    public abstract class Veiculo
    {
        [Key]
        [Required]
        public long id {get; set;}
        public string cor {get; set;}
        public string marca {get; set;}
        public string modelo {get; set;}
        private string _placa;

        public Veiculo(){ }
        public Veiculo(string placa)
        {
            this.placa = placa;
        }
        public string placa
        {
            get{ return _placa; }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    _placa = value.ToUpper().Replace("-", "").Replace("_", "");
                }
            }
        }

        public override string ToString()
        {
            return "Placa: " + this.placa + " Cor: " + this.cor + " Modelo: " + this.modelo + " Marca: " + this.marca;
        }

        public string ToString(bool imprimePlaca)
        {
            if(imprimePlaca)
            {
                return "Placa: " + this.placa;
            }
            return ToString();
        }

        public abstract int QuantidadeDePneus();
    }
    
}