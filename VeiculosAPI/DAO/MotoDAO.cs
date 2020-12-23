using System;
using System.Linq;

namespace VeiculosAPI.DAO
{
    
    public class MotoDAO
    {
        public static Moto GetMotos(long id)
        {
            try
            {
                VeiculosContext ctx = new VeiculosContext();
                var query = ctx.Moto.Where(m => m.id == id);
                return query.First();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}