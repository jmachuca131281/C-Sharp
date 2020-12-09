using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class ProviderDAO : ProviderContex
    {
        public static void AddProvider(PROVIDERS providers)
        {
            try
            {
                db.PROVIDERS.InsertOnSubmit(providers);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public static List<PROVIDERS> GetProvider()
        {
            return db.PROVIDERS.ToList();
        }

        public static void UpdateProvider(PROVIDERS providers)
        {
            try
            {
                PROVIDERS prov = db.PROVIDERS.First(x => x.id == providers.id);
                prov.provider = providers.provider;
                db.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DeleteProvider(int id)
        {
            try
            {
                PROVIDERS prov = db.PROVIDERS.First(x => x.id == id);
                db.PROVIDERS.DeleteOnSubmit(prov);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
