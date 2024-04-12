using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace NewProject.Filters
{
    public class ResultFilterAdd : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            var viewResult = context.Result as ViewResult;
            var latestBookList = viewResult.Model as List<string>;
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            var viewResult = context.Result as ViewResult;
            var newBookList = viewResult.Model as List<string>;

            newBookList.Add("book9");
            newBookList.Add("book25");
        }
    }
}
