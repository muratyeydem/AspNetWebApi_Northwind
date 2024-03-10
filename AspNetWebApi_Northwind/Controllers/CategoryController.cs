using AspNetWebApi_Northwind.DTOs;
using AspNetWebApi_Northwind.Models.Entities;
using AspNetWebApi_Northwind.Repository.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApi_Northwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryRepository categoryRepository;
        IMapper mapper;
        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;

        }
        [HttpGet]
        public List<CategoryDTO> Get()
        {
            var categories = categoryRepository.GetAll();
            List<CategoryDTO> categoryDTOs = mapper.Map<List<CategoryDTO>>(categories);
            return categoryDTOs;
        }
        [HttpPost]
        public bool Add(CategoryDTO categoryDTO)
        {
            try
            {
                var category = mapper.Map<Category>(categoryDTO);
                categoryRepository.Add(category);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        [HttpDelete]
        public bool Remove(int id)
        {
            try
            {
                var silinecekcategory = categoryRepository.GetById(x=>x.CategoryId==id);

                if (silinecekcategory==null)
                {
                    return false;
                }
                
                categoryRepository.Remove(silinecekcategory);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        [HttpPut]
        public bool Edit(CategoryUpdateDTO categoryDTO)
        {
            try
            {
                var category = mapper.Map<Category>(categoryDTO);
                categoryRepository.Edit(category);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
