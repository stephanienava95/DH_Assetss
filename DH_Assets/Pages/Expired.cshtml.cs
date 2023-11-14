using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DH_Assets.Pages
{
    public class ExpiredModel : PageModel
    {
        private readonly ILogger<ExpiredModel> _logger;

        public ExpiredModel(ILogger<ExpiredModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}