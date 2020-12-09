using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class ProductsDAO : ProviderContex
    {
        public static void AddProducts(PRODUCTS products)
        {
            try
            {
                db.PRODUCTS.InsertOnSubmit(products);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<PRODUCTS> GetProducts()
        {
            return db.PRODUCTS.ToList();
        }

        public static void UpdateProducts(PRODUCTS products)
        {
            try
            {
                PRODUCTS prod = db.PRODUCTS.First(x => x.id == products.id);
                prod.description = products.description;
                prod.category = products.category;
                prod.provider = products.provider;
                prod.price = products.price;
                prod.iva = products.iva;
                prod.quantity = products.quantity;
                db.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DeleteProduct(int id)
        {
            try
            {
                PRODUCTS product = db.PRODUCTS.First(x => x.id == id);
                db.PRODUCTS.DeleteOnSubmit(product);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
