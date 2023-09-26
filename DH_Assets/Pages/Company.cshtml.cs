using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DH_Assets.Pages
{
    public class CompanyModel : PageModel
    {
        private readonly ILogger<CompanyModel> _logger;

        public CompanyModel(ILogger<CompanyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}