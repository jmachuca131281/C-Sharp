using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class CategorysDAO : ProviderContex
    {
        public static void AddCategory(CATEGORYS category)
        {
            try
            {
                db.CATEGORYS.InsertOnSubmit(category);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<CATEGORYS> GetCategorys()
        {
            return db.CATEGORYS.ToList();
        }

        public static void updateCategory(CATEGORYS category)
        {
            try
            {
                CATEGORYS ctg = db.CATEGORYS.First(x => x.id == category.id);
                ctg.category = category.category;
                db.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DeleteCategory(int id)
        {
            try
            {
                CATEGORYS ctg = db.CATEGORYS.First(x => x.id == id);
                db.CATEGORYS.DeleteOnSubmit(ctg);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
