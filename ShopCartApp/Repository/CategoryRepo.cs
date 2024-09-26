using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopCartApp.Entities;
using ShopCartApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCartApp.Repository
{
    public class CategoryRepo : ICategoryRepo
    {
        private DemoDbContext _demoDbContext;
        private ILogger _logger;
        private IMapper _mapper;
        public CategoryRepo(DemoDbContext demoDbContext,ILoggerFactory loggerFactory,IMapper mapper)
        { 
            _demoDbContext = demoDbContext;
            _logger = loggerFactory.CreateLogger<CategoryRepo>();
            _mapper = mapper;
        }
        public List<CategoryDto> GetCategories()
        {
            List<CategoryDto> categoryDtos = new List<CategoryDto>();
            try
            {
               var categories = _demoDbContext.Categories.ToList();
               categoryDtos = _mapper.Map<List<CategoryDto>>(categories);
             
                
            }catch(Exception e)
            {
                string message = (e.InnerException != null) ? e.InnerException.Message : e.Message;
               _logger.LogError(message);
            }

            return categoryDtos;
        }
    }
}
