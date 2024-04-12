using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using NewProject.Models;

namespace NewProject.Filters
{
    public class ResourceFilterAdd : IResourceFilter
    {

        private readonly IMemoryCache _memoryCache;

        public ResourceFilterAdd(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine("I am coming from Resource Executed Filter");
            var viewResult = context.Result as ViewResult;
            var newBookList = viewResult.Model as List<string>;

            _memoryCache.Set("Books", newBookList);
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine("I am coming from Resource Executing Filter");
            if(!_memoryCache.TryGetValue("Books",out _))
            {
                var bookList = Books.BookList;// reperesnts database
                _memoryCache.Set("Books",bookList);
            }
        }
    }
}
