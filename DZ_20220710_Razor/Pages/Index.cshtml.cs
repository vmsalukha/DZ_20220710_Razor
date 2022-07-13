using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZ_20220710_Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string DayYear { get; set; }
        public string RandLetter { get; set; }
        public void OnGet()
        {
            DayYear = DateTime.Today.DayOfYear.ToString();//номер поточного дня в році.
            
            Random rand = new Random();
            RandLetter += (char)rand.Next('\u0041', '\u007A');

        }
    }
}
