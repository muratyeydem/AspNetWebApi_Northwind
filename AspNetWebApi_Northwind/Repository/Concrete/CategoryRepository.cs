using AspNetWebApi_Northwind.Models.Entities;
using AspNetWebApi_Northwind.Repository.Abstract;
using AspNetWebApi_Northwind.Repository.Interface;

namespace AspNetWebApi_Northwind.Repository.Concrete
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
