using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;

namespace BLL
{
    public class ProductsBLL
    {
        public static void AddProducts(PRODUCTS products)
        {
            ProductsDAO.AddProducts(products);
        }

        public static List<PRODUCTS> GetProducts()
        {
            return ProductsDAO.GetProducts();
        }

        public static void UpdateProduct(PRODUCTS products)
        {
            ProductsDAO.UpdateProducts(products);
        }

        public static void DeleteProduct(int id)
        {
            ProductsDAO.DeleteProduct(id);
        }
    }
}
