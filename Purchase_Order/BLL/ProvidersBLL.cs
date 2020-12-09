using DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ProvidersBLL
    {
        public static void AddProvider(PROVIDERS providers)
        {
            DAL.DAO.ProviderDAO.AddProvider(providers);
        }

        public static List<PROVIDERS> GetProviders()
        {
            return ProviderDAO.GetProvider();
        }

        public static void UpdateProvider(PROVIDERS providers)
        {
            ProviderDAO.UpdateProvider(providers);
        }

        public static void DeleteProvider(int id)
        {
            ProviderDAO.DeleteProvider(id);
        }
    }
}
