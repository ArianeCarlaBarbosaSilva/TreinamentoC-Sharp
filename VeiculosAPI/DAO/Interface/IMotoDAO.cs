using System;
using System.Linq;
using VeiculosAPI.Entities;

namespace VeiculosAPI.DAO
{
    
    public interface IMotoDAO
    {
        Moto GetMoto(long id);
        Moto AddMoto(Moto moto);
        List<Moto> AddAllMotos(List<Moto> motos);
        Moto UpdateMoto(Moto moto, long id);
        Moto DeleteMoto(long id);
    }
}