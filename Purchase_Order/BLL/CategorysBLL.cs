using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;

namespace BLL
{
    public class CategorysBLL
    {
        public static void AddCategory(CATEGORYS category)
        {
            CategorysDAO.AddCategory(category);
        }

        public static List<CATEGORYS> GetCategorys()
        {
            return CategorysDAO.GetCategorys();
        }

        public static void UpdateCategory(CATEGORYS category)
        {
            CategorysDAO.updateCategory(category);
        }

        public static void DeleteCategory(int id)
        {
            CategorysDAO.DeleteCategory(id);
        }
    }
}
