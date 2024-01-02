using Infinite_LMS_NETCore_MVC.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infinite_LMS_NETCore_MVC.Extension
{
    public static class ConvertExtenstions
    {
        public static List<SelectListItem> ConvertToSelectedList<T>(this IEnumerable<T> collection,int selectedValue)where T:IPrimaryProperties
        {
            return(
                from item in collection
                select new SelectListItem
                {
                    Text=item.Title,
                    Value=item.Id.ToString(),
                    Selected=(item.Id == selectedValue)
                }
                ).ToList();
        }
    }
}
