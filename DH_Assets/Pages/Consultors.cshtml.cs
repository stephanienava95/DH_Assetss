using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DH_Assets.Pages
{
    public class ConsultorsModel : PageModel
    {
        private readonly ILogger<ConsultorsModel> _logger;

        public ConsultorsModel(ILogger<ConsultorsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}