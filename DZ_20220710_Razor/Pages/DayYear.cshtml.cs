using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace DZ_20220710_Razor.Pages
{
    public class DayYearModel : PageModel
    {
        public string DayYear { get; set; }
        public void OnGet()
        {
            DayYear = DateTime.Today.DayOfYear.ToString();//номер поточного дня в році
        }
    }
}
