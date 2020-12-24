using System;
using System.Linq;
using VeiculosAPI.Entities;

namespace VeiculosAPI.DAO
{
    
    public class MotoDAO : IMotoDAO
    {
        public Moto GetMoto(long id)
        {
            try
            {
                using (VeiculosContext ctx = new VeiculosContext())
                {
                    var query = ctx.Moto.Where(m => m.id == id);
                    return query.First();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Moto AddMoto(Moto moto)
        {
            try
            {
                //cria um contexto auto-gerenciável que fecha as conexões no seu fim.
                using(VeiculosContext ctx = new VeiculosContext())
                {
                    var createdMoto = ctx.Moto.Add(moto);
                    ctx.SaveChanges();
                    return createdMoto.Entity;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Moto> AddAllMotos(List<Moto> motos)
        {
            try
            {
                using(VeiculosContext ctx = new VeiculosContext())
                {
                    foreach(var moto in motos)
                    {
                        var createdMoto = ctx.Moto.Add(moto);                    
                    }
                    ctx.SaveChanges(); //como se fosse o commit no BD
                }
                return motos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Moto UpdateMoto(Moto moto, long id)
        {
            try
            {
                using(VeiculosContext ctx = new VeiculosContext())
                {
                    var motoToUpdate = ctx.Moto.Where(m => m.id == id).;
                    motoToUpdate.marca = moto.marca;
                    motoToUpdate.modelo = moto.modelo;
                    motoToUpdate.cor = moto.cor;
                    motoToUpdate.placa = moto.placa;
                    motoToUpdate.numeroQuedas = moto.numeroQuedas;
                    motoToUpdate.capotesDoGustavao = moto.capotesDoGustavao;
                    ctx.SaveChanges();
                    return motoToUpdate;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Moto DeleteMoto(long id)
        {
            try
            {
                using (VeiculosContext ctx = new VeiculosContext())
                {
                    var motoToDelete = ctx.Moto.Where(m => m.id == id);
                    ctx.Moto.Remove(motoToDelete);
                    return motoToDelete; //Estou com dúvidas se esseretorno funciona uma ez que apagamos o registro
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}