using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DH_Assets.Pages
{
    public class InventaryModel : PageModel
    {
        private readonly ILogger<InventaryModel> _logger;

        public InventaryModel(ILogger<InventaryModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}