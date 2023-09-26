using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DH_Assets.Pages
{
    public class DevicesModel : PageModel
    {
        private readonly ILogger<DevicesModel> _logger;

        public DevicesModel(ILogger<DevicesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}